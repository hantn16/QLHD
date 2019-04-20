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
using DevExpress.XtraGrid.Views.Base;

namespace QLHD.UI.Views.PaymentPeriod
{
    [ViewType("PaymentPeriodCollectionView")]
    public partial class PaymentPeriodsView : UserControl
    {
        public PaymentPeriodsView()
        {
            InitializeComponent();
            InitBindings();
        }

        private void InitBindings()
        {
            var fluent = mvvmContext1.OfType<PaymentPeriodCollectionViewModel>();
            fluent.SetBinding(gridView1, gView => gView.LoadingPanelVisible, x => x.IsLoading);
            fluent.SetBinding(gridControl1, gControl => gControl.DataSource, x => x.Entities);
            fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridView1, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEntity, args => args.Row as QLHD.Model.Models.PaymentPeriod,
                (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
        }
    }
}
