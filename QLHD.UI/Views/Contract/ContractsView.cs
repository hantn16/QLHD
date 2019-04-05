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
using QLHD.Model.Models;

namespace QLHD.UI.Views.Contract
{
    [DevExpress.Utils.MVVM.UI.ViewType("ContractCollectionView")]
    public partial class ContractsView : UserControl
    {
        public ContractsView()
        {
            InitializeComponent();
            var fluent = mvvmContext1.OfType<ContractCollectionViewModel>();
            fluent.SetBinding(gridView1, gView => gView.LoadingPanelVisible, x => x.IsLoading);
            fluent.SetBinding(gridControl1, gControl => gControl.DataSource, x => x.Entities);
            fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridView1, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEntity, args => args.Row as QLHD.Model.Models.Contract,
                (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
        }

        private void gridView1_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "Work")
            {
                QLHD.Model.Models.Work work = (QLHD.Model.Models.Work)e.Value;
                e.DisplayText = work.Name;
            }
                
        }
    }
}
