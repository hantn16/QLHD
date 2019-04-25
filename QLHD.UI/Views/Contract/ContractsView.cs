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
using DevExpress.XtraEditors.Repository;
using QLHD.Model.Models;
using QLHD.UI.Views.Commons;
using DevExpress.XtraGrid.Views.Grid;

namespace QLHD.UI.Views.Contract
{
    [DevExpress.Utils.MVVM.UI.ViewType("ContractCollectionView")]
    public partial class ContractsView : UserControl
    {
        public ContractsView()
        {
            InitializeComponent();
            InitBindings();
            CustomizeGridControl();

        }

        private void CustomizeGridControl()
        {
            GridView gv = (GridView)gridControl1.MainView;
            GridControlConfig.SetColumnsHide(gv, new List<string> { "WorkId", "ContractorId", "ContractApendixes", "PaymentPeriods" });
            GridControlConfig.CommonFormat(gv);
        }

        private void InitBindings()
        {
            var fluent = mvvmContext1.OfType<ContractCollectionViewModel>();
            fluent.SetBinding(gridView1, gView => gView.LoadingPanelVisible, x => x.IsLoading);
            fluent.SetBinding(gridControl1, gControl => gControl.DataSource, x => x.Entities);
            fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridView1, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEntity, args => args.Row as QLHD.Model.Models.Contract,
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
    }
}
