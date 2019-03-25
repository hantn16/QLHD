using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using QLHD.Data;
using QLHD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QLHD.UI.QLHDDbContextDataModel {

    /// <summary>
    /// A QLHDDbContextUnitOfWork instance that represents the run-time implementation of the IQLHDDbContextUnitOfWork interface.
    /// </summary>
    public class QLHDDbContextUnitOfWork : DbUnitOfWork<QLHDDbContext>, IQLHDDbContextUnitOfWork {

        public QLHDDbContextUnitOfWork(Func<QLHDDbContext> contextFactory)
            : base(contextFactory) {
        }

        IRepository<ContractApendix, int> IQLHDDbContextUnitOfWork.ContractApendixes {
            get { return GetRepository(x => x.Set<ContractApendix>(), (ContractApendix x) => x.Id); }
        }

        IRepository<Contract, int> IQLHDDbContextUnitOfWork.Contracts {
            get { return GetRepository(x => x.Set<Contract>(), (Contract x) => x.Id); }
        }

        IRepository<Contractor, int> IQLHDDbContextUnitOfWork.Contractors {
            get { return GetRepository(x => x.Set<Contractor>(), (Contractor x) => x.Id); }
        }

        IRepository<PaymentPeriod, int> IQLHDDbContextUnitOfWork.PaymentPeriods {
            get { return GetRepository(x => x.Set<PaymentPeriod>(), (PaymentPeriod x) => x.Id); }
        }

        IRepository<Work, int> IQLHDDbContextUnitOfWork.Works {
            get { return GetRepository(x => x.Set<Work>(), (Work x) => x.Id); }
        }

        IRepository<Project, int> IQLHDDbContextUnitOfWork.Projects {
            get { return GetRepository(x => x.Set<Project>(), (Project x) => x.Id); }
        }
    }
}
