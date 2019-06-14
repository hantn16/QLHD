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
    /// Represents the single ContractApendix object view model.
    /// </summary>
    public partial class ContractApendixViewModel : SingleObjectViewModel<ContractApendix, int, IQLHDDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ContractApendixViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ContractApendixViewModel Create(IUnitOfWorkFactory<IQLHDDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ContractApendixViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ContractApendixViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ContractApendixViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ContractApendixViewModel(IUnitOfWorkFactory<IQLHDDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.ContractApendixes, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Contracts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Contract> LookUpContracts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ContractApendixViewModel x) => x.LookUpContracts,
                    getRepositoryFunc: x => x.Contracts);
            }
        }

    }
}
