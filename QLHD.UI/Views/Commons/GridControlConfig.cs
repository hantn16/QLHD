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
            foreach (string item in listColumnName)
            {
                if (item.Length > 0)
                {
                    gridView.Columns[item].Visible = false;
                }              
            }
        }
    }
}
