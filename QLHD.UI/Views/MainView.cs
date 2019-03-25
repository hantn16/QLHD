﻿using DevExpress.Mvvm;
using QLHD.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHD.UI.Views
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            if (!DesignMode)
                InitializeNavigation();
            ribbonControl1.Merge += ribbonControl1_Merge;
        }
        void ribbonControl1_Merge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e)
        {
            ribbonControl1.SelectedPage = e.MergedChild.SelectedPage;
        }
        void InitializeNavigation()
        {
            var fluentAPI = mvvmContext1.OfType<QLHDDbContextViewModel>();
            fluentAPI.BindCommand(biContracts, (x, m) => x.Show(m), x => x.Modules[0]);
            fluentAPI.BindCommand(biContractors, (x, m) => x.Show(m), x => x.Modules[1]);
            fluentAPI.BindCommand(biProjects, (x, m) => x.Show(m), x => x.Modules[2]);
            fluentAPI.BindCommand(biPaymentPeriods, (x, m) => x.Show(m), x => x.Modules[3]);
            fluentAPI.BindCommand(biWorks, (x, m) => x.Show(m), x => x.Modules[4]);
            //
            //fluentAPI.BindCommand(biLogout, x => x.Logout());
            //
            fluentAPI.WithEvent(this, "Load")
                .EventToCommand(x => x.OnLoaded(null), x => x.DefaultModule);
            //fluentAPI.WithEvent<FormClosingEventArgs>(this, "FormClosing")
            //    .EventToCommand(x => x.OnClosing(null), new Func<CancelEventArgs, object>((args) => args));
            //fluentAPI.SetTrigger(x => x.State, (state) =>
            //{
            //    if (state == AppState.Authorized)
            //        Opacity = 1; /*Show Main Form*/
            //    if (state == AppState.ExitQueued)
            //        Close(); // exit the app;
            //});
            //Messenger.Default.Register<string>(this, OnUserNameMessage);
        }
    }
}