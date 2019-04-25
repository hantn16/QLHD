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
using QLHD.UI.Views.Commons;
using DevExpress.Mvvm.POCO;

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
            CustomizeGridView();

        }

        private void CustomizeGridView()
        {
            GridControlConfig.SetColumnsHide(searchLookUpEdit1View, new List<string> { "Works", "Contracts" });
            GridControlConfig.CommonFormat(searchLookUpEdit1View);
        }

        private void InitialBindings()
        {
            var fluent = mvvmContext1.OfType<WorkViewModel>();
            fluent.SetObjectDataSourceBinding(workBindingSource, x => x.Entity, x => x.Update());
            fluent.SetBinding(projectBindingSource, pbs => pbs.DataSource, x => x.LookUpProjects.Entities);
            fluent.SetBinding(workBindingSource1, pbs => pbs.DataSource, x => x.LookUpWorks.Entities);
            fluent.SetBinding(costTypeBindingSource, bs => bs.DataSource, x => x.LookUpCostTypes.Entities);
            //fluent.BindCommand<ProjectCollectionViewModel>(this.ProjectIdLookUpEdit.Properties.View.A, (w, p) => p.New());
        }

        private void ProjectIdLookUpEdit_AddNewValue(object sender, DevExpress.XtraEditors.Controls.AddNewValueEventArgs e)
        {
            //var vm = ViewModelSource.Create<ProjectViewModel>();
        }
    }
}
