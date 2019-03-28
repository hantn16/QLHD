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
            gv.OptionsBehavior.Editable = false;
            List<String> listHideColumnName = new List<string> { "Works", "Contracts" };
            foreach (string item in listHideColumnName)
            {
                gv.Columns[item].Visible = false;
            }
        }
        void InitBindings()
        {
            var fluent = mvvmContext1.OfType<ProjectCollectionViewModel>();
            fluent.SetBinding(gridView1, gView => gView.LoadingPanelVisible, x => x.IsLoading);
            fluent.SetBinding(gridControl1, gControl => gControl.DataSource, x => x.Entities);
            fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridView1, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEntity, args => args.Row as QLHD.Model.Models.Project,
                (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
        }
    }
}
