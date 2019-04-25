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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.Utils.MVVM.UI;
using QLHD.UI.Views.Commons;

namespace QLHD.UI.Views.Invoice
{
    [ViewType("InvoiceCollectionView")]
    public partial class InvoicesView : UserControl
    {
        public InvoicesView()
        {
            InitializeComponent();
            InitBindings();
            CustomizeGridControl();
        }

        private void CustomizeGridControl()
        {
            GridView gv = (GridView)gridControl1.MainView;
            GridControlConfig.SetColumnsHide(gv, new List<string> { "PaymentPeriodId"});
            GridControlConfig.CommonFormat(gv);
            gv.OptionsView.ShowAutoFilterRow = true;
        }

        private void InitBindings()
        {
            var fluent = mvvmContext1.OfType<InvoiceCollectionViewModel>();
            fluent.SetBinding(gridView1, gv => gv.LoadingPanelVisible, x => x.IsLoading);
            fluent.SetBinding(gridControl1, gc => gc.DataSource, vm => vm.Entities);
            fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridView1, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEntity, args => args.Row as QLHD.Model.Models.Invoice,
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
