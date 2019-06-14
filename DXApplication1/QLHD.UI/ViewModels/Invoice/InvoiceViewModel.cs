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
    /// Represents the single Invoice object view model.
    /// </summary>
    public partial class InvoiceViewModel : SingleObjectViewModel<Invoice, int, IQLHDDbContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of InvoiceViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static InvoiceViewModel Create(IUnitOfWorkFactory<IQLHDDbContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new InvoiceViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the InvoiceViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the InvoiceViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected InvoiceViewModel(IUnitOfWorkFactory<IQLHDDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Invoices, x => x.Number) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of PaymentPeriods for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<PaymentPeriod> LookUpPaymentPeriods {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (InvoiceViewModel x) => x.LookUpPaymentPeriods,
                    getRepositoryFunc: x => x.PaymentPeriods);
            }
        }

    }
}
