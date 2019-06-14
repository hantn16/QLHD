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
    /// Represents the single Contractor object view model.
    /// </summary>
    public partial class ContractorViewModel : SingleObjectViewModel<Contractor, int, IQLHDDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ContractorViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ContractorViewModel Create(IUnitOfWorkFactory<IQLHDDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ContractorViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ContractorViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ContractorViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ContractorViewModel(IUnitOfWorkFactory<IQLHDDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Contractors, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Contracts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Contract> LookUpContracts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ContractorViewModel x) => x.LookUpContracts,
                    getRepositoryFunc: x => x.Contracts);
            }
        }


        /// <summary>
        /// The view model for the ContractorContracts detail collection.
        /// </summary>
        public CollectionViewModelBase<Contract, Contract, int, IQLHDDbContextUnitOfWork> ContractorContractsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ContractorViewModel x) => x.ContractorContractsDetails,
                    getRepositoryFunc: x => x.Contracts,
                    foreignKeyExpression: x => x.ContractorId,
                    navigationExpression: x => x.Contractor);
            }
        }
    }
}
