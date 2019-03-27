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
            gv.OptionsBehavior.Editable = false;
            List<String> listHideColumnName = new List<string> { "Project","Contracts"};
            foreach (string item in listHideColumnName)
            {
                gv.Columns[item].Visible = false;
            }
        }

        private void InitBindings()
        {
            var fluent = mvvmContext1.OfType<WorkCollectionViewModel>();
            fluent.SetBinding(gridView1, gView => gView.LoadingPanelVisible, x => x.IsLoading);
            fluent.SetBinding(gridControl1, gControl => gControl.DataSource, x => x.Entities);
            fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridView1, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEntity, args => args.Row as QLHD.Model.Models.Work,
                (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
        }
    }
}
