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
using QLHD.UI.Views.Commons;
using DevExpress.XtraGrid;
using DevExpress.Data;
using System.Data.Entity;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;

namespace QLHD.UI.Views.Work
{
    [DevExpress.Utils.MVVM.UI.ViewType("WorkCollectionView")]
    public partial class WorksView : UserControl
    {
        public WorksView()
        {
            InitializeComponent();
            InitBindings();
            CustomizeGridView();
        }

        void CustomizeGridView()
        {
            GridView gv = (GridView)gridControl1.MainView;
            GridControlConfig.SetColumnsHide(gv, new List<string> { "ProjectId", "Contracts", "ParentWorkId", "ChildWorks","CostTypeId" });
            GridControlConfig.CommonFormat(gv,true);
            gv.OptionsView.ShowAutoFilterRow = true;
            //gv.BestFitColumns();
        }

        private void InitBindings()
        {
            var fluent = mvvmContext1.OfType<WorkCollectionViewModel>();
            fluent.SetBinding(gridView1, gView => gView.LoadingPanelVisible, x => x.IsLoading);
            fluent.SetBinding(gridControl1, gControl => gControl.DataSource, x => x.Entities);
            fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridView1, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEntity, args => args.Row as QLHD.Model.Models.Work,
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
            //fluent.WithEvent<SelectionChangedEventArgs>(gridView1, "SelectionChanged")
            //    .SetBinding(x => x.Selection, e => GetSelectedWorks());
            //IEnumerable<QLHD.Model.Models.Work> GetSelectedWorks()
            //{
            //    return gridView1.GetSelectedRows().Select(r => gridView1.GetRow(r) as QLHD.Model.Models.Work);
            //}
            fluent.WithEvent<SelectionChangedEventArgs>(gridView1, "SelectionChanged")
                .SetBinding(x => x.Selection, e => gridView1.GetSelectedRows().Select(r => gridView1.GetRow(r) as QLHD.Model.Models.Work));
        }


        private void gridControl1_DataSourceChanged(object sender, EventArgs e)
        {
            GridControl gc = (GridControl)sender;
            GridView gv = (GridView)gc.MainView;

            GridControlConfig.CommonFormat(gv,true);
            RepositoryItemMemoEdit memoEdit = new RepositoryItemMemoEdit();
            memoEdit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            if (gv.Columns.Any(x => x.FieldName == "Name") && gv.Columns.Any(x => x.FieldName == "Project"))
            {
                gv.Columns["Name"].ColumnEdit = memoEdit;
                gv.Columns["Project"].ColumnEdit = memoEdit;
            }
            gv.Columns.ColumnByFieldName("CostType").FilterMode = ColumnFilterMode.DisplayText;
            gv.BestFitColumns();
            //MessageBox.Show(String.Join(", ", gv.Columns.Select(x => x.FieldName).ToArray<string>()));
        }

        private void bbiPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check whether the GridControl can be previewed. 
            if (!gridControl1.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            // Open the Preview window. 
            gridControl1.ShowPrintPreview();
        }

        //private void gridView1_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        //{
        //    GridView view = sender as GridView;
        //    if (view == null) return;
        //    int rowIndex = e.ListSourceRowIndex;
        //    if (e.Column.FieldName != "OrderNo") return;
        //    if (e.IsGetData)
        //        e.Value = view.GetRowHandle(rowIndex)+1;
        //}
    }
}
