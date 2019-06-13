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
using DevExpress.Data;

namespace QLHD.UI.Views.Project
{
    [DevExpress.Utils.MVVM.UI.ViewType("ProjectCollectionView")]
    public partial class ProjectsView : UserControl
    {
        public ProjectsView()
        {
            InitializeComponent();
            InitBindings();
            CustomizeGridView();
        }
        void CustomizeGridView()
        {
            GridView gv = (GridView)gridControl1.MainView;
            GridControlConfig.CommonFormat(gv);
            GridControlConfig.SetColumnsHide(gv, new List<string> { "Works", "Contracts" });
            gv.OptionsBehavior.Editable = false;
        }
        void InitBindings()
        {
            var fluent = mvvmContext1.OfType<ProjectCollectionViewModel>();
            fluent.SetBinding(gridView1, gView => gView.LoadingPanelVisible, x => x.IsLoading);
            fluent.SetBinding(gridControl1, gControl => gControl.DataSource, x => x.Entities);
            fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridView1, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEntity, args => args.Row as QLHD.Model.Models.Project,
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
            fluent.WithEvent<SelectionChangedEventArgs>(gridView1, "SelectionChanged")
                .SetBinding(x => x.Selection, e => gridView1.GetSelectedRows().Select(r => gridView1.GetRow(r) as QLHD.Model.Models.Project));
        }
    }
}
