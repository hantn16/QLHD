using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.MVVM.UI;
using QLHD.UI.ViewModels;
using QLHD.Model.Models;

namespace QLHD.UI.Views.Work
{
    [ViewType("WorkView")]
    public partial class WorksEditFormView : UserControl
    {
        public WorksEditFormView()
        {
            InitializeComponent();
            if (!DesignMode)
                InitialBindings();
            InitCostTypeList();

        }

        private void InitCostTypeList()
        {
            CostTypeComboBoxEdit.Properties.Items.AddRange(Enum.GetValues(typeof(CostType)));
        }

        private void InitialBindings()
        {
            var fluent = mvvmContext1.OfType<WorkViewModel>();
            fluent.SetObjectDataSourceBinding(workBindingSource, x => x.Entity, x => x.Update());
            fluent.SetBinding(projectBindingSource, pbs => pbs.DataSource, x => x.LookUpProjects.Entities);
        }
    }
}
