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
        }


        private void gridControl1_DataSourceChanged(object sender, EventArgs e)
        {
            GridControl gc = (GridControl)sender;
            GridView gv = (GridView)gc.MainView;
            gv.BestFitColumns();
        }
    }
}
