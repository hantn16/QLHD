using DevExpress.Mvvm.DataModel;
using QLHD.Data;
using QLHD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QLHD.UI.QLHDDbContextDataModel {

    /// <summary>
    /// IQLHDDbContextUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IQLHDDbContextUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The ContractApendix entities repository.
        /// </summary>
		IRepository<ContractApendix, int> ContractApendixes { get; }
        
        /// <summary>
        /// The Contract entities repository.
        /// </summary>
		IRepository<Contract, int> Contracts { get; }
        
        /// <summary>
        /// The Contractor entities repository.
        /// </summary>
		IRepository<Contractor, int> Contractors { get; }
        
        /// <summary>
        /// The PaymentPeriod entities repository.
        /// </summary>
		IRepository<PaymentPeriod, int> PaymentPeriods { get; }
        
        /// <summary>
        /// The Work entities repository.
        /// </summary>
		IRepository<Work, int> Works { get; }
        
        /// <summary>
        /// The Project entities repository.
        /// </summary>
		IRepository<Project, int> Projects { get; }
    }
}
