using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using QLHD.UI.QLHDDbContextDataModel;
using QLHD.UI.Common;
using QLHD.Model.Models;

namespace QLHD.UI.ViewModels {

    /// <summary>
    /// Represents the CostTypes collection view model.
    /// </summary>
    public partial class CostTypeCollectionViewModel : CollectionViewModel<CostType, int, IQLHDDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CostTypeCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CostTypeCollectionViewModel Create(IUnitOfWorkFactory<IQLHDDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CostTypeCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CostTypeCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CostTypeCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CostTypeCollectionViewModel(IUnitOfWorkFactory<IQLHDDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.CostTypes) {
        }
    }
}