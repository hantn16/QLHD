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
    /// Represents the single CostType object view model.
    /// </summary>
    public partial class CostTypeViewModel : SingleObjectViewModel<CostType, int, IQLHDDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CostTypeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CostTypeViewModel Create(IUnitOfWorkFactory<IQLHDDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CostTypeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CostTypeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CostTypeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CostTypeViewModel(IUnitOfWorkFactory<IQLHDDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.CostTypes, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Works for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Work> LookUpWorks {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CostTypeViewModel x) => x.LookUpWorks,
                    getRepositoryFunc: x => x.Works);
            }
        }


        /// <summary>
        /// The view model for the CostTypeWorks detail collection.
        /// </summary>
        public CollectionViewModelBase<Work, Work, int, IQLHDDbContextUnitOfWork> CostTypeWorksDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (CostTypeViewModel x) => x.CostTypeWorksDetails,
                    getRepositoryFunc: x => x.Works,
                    foreignKeyExpression: x => x.CostTypeId,
                    navigationExpression: x => x.CostType);
            }
        }
    }
}
