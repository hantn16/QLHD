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

namespace QLHD.UI.Views.Project
{
    [ViewType("ProjectView")]
    public partial class ProjectsEditFormView : UserControl
    {
        public ProjectsEditFormView()
        {
            InitializeComponent();
            var fluent = mvvmContext1.OfType<ProjectViewModel>();
            fluent.SetObjectDataSourceBinding(
                projectBindingSource, x => x.Entity, x => x.Update());
        }
    }
}
