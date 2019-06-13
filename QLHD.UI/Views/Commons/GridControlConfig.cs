using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHD.UI.Views.Commons
{
    public static class GridControlConfig
    {
        public static void SetColumnsHide(GridView gridView, List<String> listColumnName)
        {
            if (gridView.Columns.Count > 0)
            {
                foreach (string item in listColumnName)
                {
                    if (item.Length > 0)
                    {
                        gridView.Columns[item].Visible = false;
                    }
                }
            }

        }
        public static void CommonFormat(GridView gv)
        {
            //*****Config GridView*****
            // Căn giữa header
            gv.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gv.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            gv.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            //Enable Multi-select mode
            gv.OptionsSelection.MultiSelect = true;
            gv.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
            gv.OptionsView.RowAutoHeight = true;
            //gv.OptionsView.ColumnAutoWidth = false;
            //*****Config GridColumn*****
            
            foreach (GridColumn cl in gv.Columns)
            {
                // Định dạng theo ColumnType
                if (cl.ColumnType == typeof(double) || cl.ColumnType == typeof(int))
                {
                    cl.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
                    cl.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
                }
                else if (cl.ColumnType == typeof(DateTime))
                {
                    cl.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
                    cl.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                }
                else
                {
                    cl.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    cl.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
                }
            }
        }
        public static void CommonFormat(GridView gv,bool AddOrderNoColumn = false)
        {
            CommonFormat(gv);
            if (AddOrderNoColumn && gv.Columns.ColumnByFieldName("OrderNo") == null)
            {
                GridColumn gcl = gv.Columns.AddVisible("OrderNo", "STT");
                gcl.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
                gcl.VisibleIndex = 0;
                gcl.MaxWidth = 40;
                gcl.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            gv.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(gv_CustomUnboundColumnData);
        }

        private static void gv_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null) return;
            int rowIndex = e.ListSourceRowIndex;
            if (e.Column.FieldName != "OrderNo") return;
            if (e.IsGetData)
                e.Value = view.GetRowHandle(rowIndex) + 1;
        }
    }
}
