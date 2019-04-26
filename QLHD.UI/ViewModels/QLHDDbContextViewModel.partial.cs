using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using QLHD.Model.Models;
using QLHD.UI.QLHDDbContextDataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHD.UI.ViewModels
{
    //QLHDDbContextViewModel.partial.cs 
    public partial class QLHDDbContextViewModel
    {
        LoginViewModel loginViewModel;

        /// <summary>
        /// Initializes a new instance of the QLHDDbContextViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the QLHDDbContextViewModel type without the POCO proxy factory.
        /// </summary>
        protected QLHDDbContextViewModel()
            : base(UnitOfWorkSource.GetUnitOfWorkFactory())
        {
            loginViewModel = LoginViewModel.Create();
            loginViewModel.SetParentViewModel(this);
        }
        protected IDialogService DialogService
        {
            get { return this.GetService<IDialogService>(); }
        }
        protected IMessageBoxService MessageService
        {
            get { return this.GetService<IMessageBoxService>(); }
        }

        public override void OnLoaded(QLHDDbContextModuleDescription module)
        {
            base.OnLoaded(module);
            Login();
        }
        public override void OnClosing(CancelEventArgs cancelEventArgs)
        {
            base.OnClosing(cancelEventArgs);
            if (!cancelEventArgs.Cancel)
            {
                if (State == AppState.Authorized && MessageService.ShowMessage("Do you really want to close the application?", "Confirm", MessageButton.YesNo) == MessageResult.No)
                    cancelEventArgs.Cancel = true;
            }
        }
        public override QLHDDbContextModuleDescription DefaultModule { get { return Modules.ElementAt(2); } }
        public virtual AppState State { get; set; }
        // Shows the Login View 
        public void Login()
        {
            OnLogin(DialogService.ShowDialog(MessageButton.OKCancel, "Please enter you credentials", "LoginView", loginViewModel));
        }
        public void Logout()
        {
            State = AppState.ExitQueued;
            System.Diagnostics.Process.Start(System.Windows.Forms.Application.ExecutablePath);
        }
        public bool CanLogout()
        {
            return State == AppState.Authorized;
        }
        //Occurs whenever the end-user clicks a dialog button 
        void OnLogin(MessageResult result)
        {
            if (result == MessageResult.Cancel)
                State = AppState.ExitQueued;
            else
            {
                if (loginViewModel.IsCurrentUserCredentialsValid)
                {
                    State = AppState.Authorized;
                }
                else
                    Login();
            }
        }
        protected void OnStateChanged()
        {
            this.RaiseCanExecuteChanged(x => x.Logout());
            if (State == AppState.Authorized)
                Messenger.Default.Send<string>(loginViewModel.CurrentUser.Login);
            else
                Messenger.Default.Send<string>(string.Empty);
        }
    }

    public enum AppState
    {
        NotAuthorized,
        Authorized,
        ExitQueued
    }
}
