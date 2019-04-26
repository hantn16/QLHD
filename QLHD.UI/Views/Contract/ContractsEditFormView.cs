using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.MVVM.UI;
using QLHD.UI.ViewModels;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraEditors;
using QLHD.UI.Views.Work;
using DevExpress.XtraBars.Docking2010;

namespace QLHD.UI.Views.Contract
{
    [ViewType("ContractView")]
    public partial class ContractsEditFormView : XtraUserControl
    {
        public ContractsEditFormView()
        {
            InitializeComponent();
            if (!DesignMode)
                InitialBindings();
            
        }

        private void InitialBindings()
        {
            var fluent = mvvmContext1.OfType<ContractViewModel>();

            fluent.SetObjectDataSourceBinding(
                contractBindingSource, x => x.Entity, x => x.Update());
            fluent.SetBinding(workBindingSource, x => x.DataSource, y => y.LookUpChildWorks.Entities);
            fluent.SetBinding(contractorBindingSource, x => x.DataSource, y => y.LookUpContractors.Entities);
            fluent.BindCommand<WorkCollectionViewModel>(WorkIdTextEdit.Properties.Buttons.ElementAt(1), (x, y) => y.New());
        }

        private void WorkIdTextEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                LookUpEdit lookUpEdit = (LookUpEdit)sender;
            }
        }
    }
}
