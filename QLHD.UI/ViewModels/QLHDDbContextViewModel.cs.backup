using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using QLHD.UI.QLHDDbContextDataModel;

namespace QLHD.UI.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the QLHDDbContext data model.
    /// </summary>
    public partial class QLHDDbContextViewModel : DocumentsViewModel<QLHDDbContextModuleDescription, IQLHDDbContextUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
	
        /// <summary>
        /// Creates a new instance of QLHDDbContextViewModel as a POCO view model.
        /// </summary>
        public static QLHDDbContextViewModel Create() {
            return ViewModelSource.Create(() => new QLHDDbContextViewModel());
        }

		
        /// <summary>
        /// Initializes a new instance of the QLHDDbContextViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the QLHDDbContextViewModel type without the POCO proxy factory.
        /// </summary>
      //  protected QLHDDbContextViewModel()
		    //: base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
      //  }

        protected override QLHDDbContextModuleDescription[] CreateModules() {
			return new QLHDDbContextModuleDescription[] {              
                new QLHDDbContextModuleDescription( "Contracts", "ContractCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Contracts)),
                new QLHDDbContextModuleDescription( "Contractors", "ContractorCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Contractors)),
                new QLHDDbContextModuleDescription( "Projects", "ProjectCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Projects)),
                new QLHDDbContextModuleDescription( "Payment Periods", "PaymentPeriodCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.PaymentPeriods)),
                new QLHDDbContextModuleDescription( "Works", "WorkCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Works)),
                new QLHDDbContextModuleDescription( "Contract Apendixes", "ContractApendixCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.ContractApendixes)),
            };
        }
                	}

    public partial class QLHDDbContextModuleDescription : ModuleDescription<QLHDDbContextModuleDescription> {
        public QLHDDbContextModuleDescription(string title, string documentType, string group, Func<QLHDDbContextModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}