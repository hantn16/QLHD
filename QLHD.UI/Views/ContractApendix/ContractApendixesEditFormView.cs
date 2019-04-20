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

namespace QLHD.UI.Views.ContractApendix
{
    [ViewType("ContractApendixView")]
    public partial class ContractApendixesEditFormView : UserControl
    {
        public ContractApendixesEditFormView()
        {
            InitializeComponent();
            InitBindings();
        }

        private void InitBindings()
        {
            var fluent = mvvmContext1.OfType<ContractApendixViewModel>();
            fluent.SetObjectDataSourceBinding(contractApendixBindingSource, x => x.Entity, x => x.Update());
            fluent.SetBinding(contractBindingSource, x => x.DataSource, y => y.LookUpContracts.Entities);
        }
    }
}
