using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLHD.UI.ViewModels;
using DevExpress.Utils.MVVM.UI;

namespace QLHD.UI.Views.Invoice
{
    [ViewType("InvoiceView")]
    public partial class InvoicesEditFormView : UserControl
    {
        public InvoicesEditFormView()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                InitBindings();
            }
        }

        private void InitBindings()
        {
            var fluent = mvvmContext1.OfType<InvoiceViewModel>();
            fluent.SetObjectDataSourceBinding(invoiceBindingSource, vm => vm.Entity,vm => vm.Update());
            fluent.SetBinding(paymentPeriodBindingSource, bs => bs.DataSource, vm => vm.LookUpPaymentPeriods.Entities);
        }
    }
}
