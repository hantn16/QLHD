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

namespace QLHD.UI.Views.PaymentPeriod
{
    [ViewType("PaymentPeriodView")]
    public partial class PaymentPeriodsEditFormView : UserControl
    {
        public PaymentPeriodsEditFormView()
        {
            InitializeComponent();
            var fluent = mvvmContext1.OfType<PaymentPeriodViewModel>();
            fluent.SetObjectDataSourceBinding(
                paymentPeriodBindingSource, x => x.Entity, x => x.Update());
            fluent.SetBinding(contractBindingSource, x => x.DataSource, y => y.LookUpContracts.Entities);
        }
    }
}
