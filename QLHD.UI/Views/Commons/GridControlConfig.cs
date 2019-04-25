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
            // Căn giữa header
            gv.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            // Căn lề ô theo kiểu dữ liệu
            foreach (GridColumn cl in gv.Columns)
            {
                if (cl.ColumnType == typeof(double))
                {
                    cl.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
                }
                else
                {
                    cl.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                }
            }

        }
    }
}
