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

namespace QLHD.UI.Views.Contractor
{
    [DevExpress.Utils.MVVM.UI.ViewType("ContractorCollectionView")]
    public partial class ContractorsView : UserControl
    {
        public ContractorsView()
        {
            InitializeComponent();
            InitBindings();
            CustomizeGridView();
        }
        void InitBindings()
        {
            var fluent = mvvmContext1.OfType<ContractorCollectionViewModel>();
            fluent.SetBinding(gridView1, gView => gView.LoadingPanelVisible, x => x.IsLoading);
            fluent.SetBinding(gridControl1, gControl => gControl.DataSource, x => x.Entities);
            fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridView1, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEntity, args => args.Row as QLHD.Model.Models.Contractor,
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
        void CustomizeGridView()
        {
            GridView gv = (GridView)gridControl1.MainView;
            gv.OptionsBehavior.Editable = false;
            List<String> listHideColumnName = new List<string> { "Contracts" };
            foreach (string item in listHideColumnName)
            {
                gv.Columns[item].Visible = false;
            }
        }
    }
}
