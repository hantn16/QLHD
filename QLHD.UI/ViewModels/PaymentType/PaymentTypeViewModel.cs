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
    /// Represents the single PaymentType object view model.
    /// </summary>
    public partial class PaymentTypeViewModel : SingleObjectViewModel<PaymentType, int, IQLHDDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PaymentTypeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PaymentTypeViewModel Create(IUnitOfWorkFactory<IQLHDDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PaymentTypeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PaymentTypeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PaymentTypeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PaymentTypeViewModel(IUnitOfWorkFactory<IQLHDDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.PaymentTypes, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of PaymentPeriods for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<PaymentPeriod> LookUpPaymentPeriods {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PaymentTypeViewModel x) => x.LookUpPaymentPeriods,
                    getRepositoryFunc: x => x.PaymentPeriods);
            }
        }


        /// <summary>
        /// The view model for the PaymentTypePaymentPeriods detail collection.
        /// </summary>
        public CollectionViewModelBase<PaymentPeriod, PaymentPeriod, int, IQLHDDbContextUnitOfWork> PaymentTypePaymentPeriodsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (PaymentTypeViewModel x) => x.PaymentTypePaymentPeriodsDetails,
                    getRepositoryFunc: x => x.PaymentPeriods,
                    foreignKeyExpression: x => x.PaymentTypeId,
                    navigationExpression: x => x.PaymentType);
            }
        }
    }
}
