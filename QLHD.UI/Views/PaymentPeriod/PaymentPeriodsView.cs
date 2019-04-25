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
using DevExpress.XtraGrid.Views.Grid;
using QLHD.UI.Views.Commons;
using DevExpress.XtraGrid;

namespace QLHD.UI.Views.PaymentPeriod
{
    [ViewType("PaymentPeriodCollectionView")]
    public partial class PaymentPeriodsView : UserControl
    {
        public PaymentPeriodsView()
        {
            InitializeComponent();
            InitBindings();
            CustomizeGridControl();
        }

        private void CustomizeGridControl()
        {
            GridView gv = gridView1;
            GridControlConfig.SetColumnsHide(gv, new List<string> { "ContractId", "PaymentTypeId", "Invoices"});
            GridControlConfig.CommonFormat(gv);
            gv.OptionsView.ShowAutoFilterRow = true;
            
        }

        private void InitBindings()
        {
            var fluent = mvvmContext1.OfType<PaymentPeriodCollectionViewModel>();
            fluent.SetBinding(gridView1, gView => gView.LoadingPanelVisible, x => x.IsLoading);
            fluent.SetBinding(gridControl1, gControl => gControl.DataSource, x => x.Entities);
            fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridView1, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEntity, args => args.Row as QLHD.Model.Models.PaymentPeriod,
                (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            fluent.WithEvent<RowClickEventArgs>(gridView1, "RowClick").EventToCommand(
                x => x.Edit(null),
                x => x.SelectedEntity,
                args => (args.Clicks == 2) && (args.Button == MouseButtons.Left));
            gridView1.RowClick += (s, e) => {
                if (e.Clicks == 1 && e.Button == MouseButtons.Right)
                {
                    popupMenu1.ShowPopup(gridControl1.PointToScreen(e.Location), s);
                }
            };
        }

        private void gridControl1_DataSourceChanged(object sender, EventArgs e)
        {
            GridControl gc = (GridControl)sender;
            GridView gv = (GridView)gc.MainView;
            gv.BestFitColumns();
        }
    }
}
