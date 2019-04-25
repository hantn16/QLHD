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
    /// Represents the single Contract object view model.
    /// </summary>
    public partial class ContractViewModel : SingleObjectViewModel<Contract, int, IQLHDDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ContractViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ContractViewModel Create(IUnitOfWorkFactory<IQLHDDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ContractViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ContractViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ContractViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ContractViewModel(IUnitOfWorkFactory<IQLHDDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Contracts, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of ContractApendixes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ContractApendix> LookUpContractApendixes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ContractViewModel x) => x.LookUpContractApendixes,
                    getRepositoryFunc: x => x.ContractApendixes);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Contractors for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Contractor> LookUpContractors {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ContractViewModel x) => x.LookUpContractors,
                    getRepositoryFunc: x => x.Contractors);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Works for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Work> LookUpWorks {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ContractViewModel x) => x.LookUpWorks,
                    getRepositoryFunc: x => x.Works);
            }
        }

        /// <summary>
        /// The view model that contains a look-up collection of Works for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Work> LookUpChildWorks
        {
            get
            {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ContractViewModel x) => x.LookUpChildWorks,
                    getRepositoryFunc: x => x.Works,
                    projection: query => query.Where(work => work.ChildWorks.Count == 0));
            }
        }

        /// <summary>
        /// The view model that contains a look-up collection of PaymentPeriods for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<PaymentPeriod> LookUpPaymentPeriods {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ContractViewModel x) => x.LookUpPaymentPeriods,
                    getRepositoryFunc: x => x.PaymentPeriods);
            }
        }


        /// <summary>
        /// The view model for the ContractContractApendixes detail collection.
        /// </summary>
        public CollectionViewModelBase<ContractApendix, ContractApendix, int, IQLHDDbContextUnitOfWork> ContractContractApendixesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ContractViewModel x) => x.ContractContractApendixesDetails,
                    getRepositoryFunc: x => x.ContractApendixes,
                    foreignKeyExpression: x => x.ContractId,
                    navigationExpression: x => x.Contract);
            }
        }

        /// <summary>
        /// The view model for the ContractPaymentPeriods detail collection.
        /// </summary>
        public CollectionViewModelBase<PaymentPeriod, PaymentPeriod, int, IQLHDDbContextUnitOfWork> ContractPaymentPeriodsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ContractViewModel x) => x.ContractPaymentPeriodsDetails,
                    getRepositoryFunc: x => x.PaymentPeriods,
                    foreignKeyExpression: x => x.ContractId,
                    navigationExpression: x => x.Contract);
            }
        }
    }
}
