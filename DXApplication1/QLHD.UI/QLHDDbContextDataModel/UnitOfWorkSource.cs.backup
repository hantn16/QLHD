using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EF6;
using QLHD.Model;
using System;
using System.Collections;
using System.Linq;

namespace QLHD.UI.QLHDDbContextDataModel {

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

		/// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IQLHDDbContextUnitOfWork> GetUnitOfWorkFactory() {
            return new DbUnitOfWorkFactory<IQLHDDbContextUnitOfWork>(() => new QLHDDbContextUnitOfWork(() => new QLHDDbContext()));
        }
    }
}