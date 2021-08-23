using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using QLHD.Model;
using QLHD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QLHD.UI.QLHDDbContextDataModel {

    /// <summary>
    /// A QLHDDbContextDesignTimeUnitOfWork instance that represents the design-time implementation of the IQLHDDbContextUnitOfWork interface.
    /// </summary>
    public class QLHDDbContextDesignTimeUnitOfWork : DesignTimeUnitOfWork, IQLHDDbContextUnitOfWork {

        /// <summary>
        /// Initializes a new instance of the QLHDDbContextDesignTimeUnitOfWork class.
        /// </summary>
        public QLHDDbContextDesignTimeUnitOfWork() {
        }

        IRepository<ContractApendix, int> IQLHDDbContextUnitOfWork.ContractApendixes {
            get { return GetRepository((ContractApendix x) => x.Id); }
        }

        IRepository<Contract, int> IQLHDDbContextUnitOfWork.Contracts {
            get { return GetRepository((Contract x) => x.Id); }
        }

        IRepository<Contractor, int> IQLHDDbContextUnitOfWork.Contractors {
            get { return GetRepository((Contractor x) => x.Id); }
        }

        IRepository<PaymentPeriod, int> IQLHDDbContextUnitOfWork.PaymentPeriods {
            get { return GetRepository((PaymentPeriod x) => x.Id); }
        }

        IRepository<Invoice, int> IQLHDDbContextUnitOfWork.Invoices {
            get { return GetRepository((Invoice x) => x.Id); }
        }

        IRepository<PaymentType, int> IQLHDDbContextUnitOfWork.PaymentTypes {
            get { return GetRepository((PaymentType x) => x.Id); }
        }

        IRepository<Work, int> IQLHDDbContextUnitOfWork.Works {
            get { return GetRepository((Work x) => x.Id); }
        }

        IRepository<CostType, int> IQLHDDbContextUnitOfWork.CostTypes {
            get { return GetRepository((CostType x) => x.Id); }
        }

        IRepository<Project, int> IQLHDDbContextUnitOfWork.Projects {
            get { return GetRepository((Project x) => x.Id); }
        }

        IRepository<User, int> IQLHDDbContextUnitOfWork.Users {
            get { return GetRepository((User x) => x.Id); }
        }
    }
}
