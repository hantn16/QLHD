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
    /// Represents the single Work object view model.
    /// </summary>
    public partial class WorkViewModel : SingleObjectViewModel<Work, int, IQLHDDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of WorkViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static WorkViewModel Create(IUnitOfWorkFactory<IQLHDDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new WorkViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the WorkViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the WorkViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected WorkViewModel(IUnitOfWorkFactory<IQLHDDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Works, x => x.CreatedBy) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Contracts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Contract> LookUpContracts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (WorkViewModel x) => x.LookUpContracts,
                    getRepositoryFunc: x => x.Contracts);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Projects for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Project> LookUpProjects {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (WorkViewModel x) => x.LookUpProjects,
                    getRepositoryFunc: x => x.Projects);
            }
        }


        /// <summary>
        /// The view model for the WorkContracts detail collection.
        /// </summary>
        public CollectionViewModelBase<Contract, Contract, int, IQLHDDbContextUnitOfWork> WorkContractsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (WorkViewModel x) => x.WorkContractsDetails,
                    getRepositoryFunc: x => x.Contracts,
                    foreignKeyExpression: x => x.WorkId,
                    navigationExpression: x => x.Work);
            }
        }
    }
}
