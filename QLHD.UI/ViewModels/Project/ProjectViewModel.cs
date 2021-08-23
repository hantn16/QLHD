using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using QLHD.UI.QLHDDbContextDataModel;
using QLHD.UI.Common;
using QLHD.Model.Models;

namespace QLHD.UI.ViewModels {

    /// <summary>
    /// Represents the single Project object view model.
    /// </summary>
    public partial class ProjectViewModel : SingleObjectViewModel<Project, int, IQLHDDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ProjectViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ProjectViewModel Create(IUnitOfWorkFactory<IQLHDDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ProjectViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ProjectViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ProjectViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ProjectViewModel(IUnitOfWorkFactory<IQLHDDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Projects, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Works for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Work> LookUpWorks {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ProjectViewModel x) => x.LookUpWorks,
                    getRepositoryFunc: x => x.Works);
            }
        }


        /// <summary>
        /// The view model for the ProjectWorks detail collection.
        /// </summary>
        public CollectionViewModelBase<Work, Work, int, IQLHDDbContextUnitOfWork> ProjectWorksDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ProjectViewModel x) => x.ProjectWorksDetails,
                    getRepositoryFunc: x => x.Works,
                    foreignKeyExpression: x => x.ProjectId,
                    navigationExpression: x => x.Project);
            }
        }
    }
}
