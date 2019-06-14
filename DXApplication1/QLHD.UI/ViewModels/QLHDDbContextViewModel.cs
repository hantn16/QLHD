using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using QLHD.UI.Localization;using QLHD.UI.QLHDDbContextDataModel;

namespace QLHD.UI.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the QLHDDbContext data model.
    /// </summary>
    public partial class QLHDDbContextViewModel : DocumentsViewModel<QLHDDbContextModuleDescription, IQLHDDbContextUnitOfWork> {

		const string TablesGroup = "Danh mục";

		const string ViewsGroup = "Views";
	
        /// <summary>
        /// Creates a new instance of QLHDDbContextViewModel as a POCO view model.
        /// </summary>
        public static QLHDDbContextViewModel Create() {
            return ViewModelSource.Create(() => new QLHDDbContextViewModel());
        }

		        static QLHDDbContextViewModel() {
            MetadataLocator.Default = MetadataLocator.Create().AddMetadata<QLHDDbContextMetadataProvider>();
        }
        /// <summary>
        /// Initializes a new instance of the QLHDDbContextViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the QLHDDbContextViewModel type without the POCO proxy factory.
        /// </summary>
        protected QLHDDbContextViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override QLHDDbContextModuleDescription[] CreateModules() {
			return new QLHDDbContextModuleDescription[] {
                new QLHDDbContextModuleDescription(QLHDDbContextResources.ContractApendixPlural, "ContractApendixCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.ContractApendixes)),
                new QLHDDbContextModuleDescription(QLHDDbContextResources.ContractPlural, "ContractCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Contracts)),
                new QLHDDbContextModuleDescription(QLHDDbContextResources.ContractorPlural, "ContractorCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Contractors)),
                new QLHDDbContextModuleDescription(QLHDDbContextResources.PaymentPeriodPlural, "PaymentPeriodCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.PaymentPeriods)),
                new QLHDDbContextModuleDescription(QLHDDbContextResources.InvoicePlural, "InvoiceCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Invoices)),
                new QLHDDbContextModuleDescription(QLHDDbContextResources.PaymentTypePlural, "PaymentTypeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.PaymentTypes)),
                new QLHDDbContextModuleDescription(QLHDDbContextResources.WorkPlural, "WorkCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Works)),
                new QLHDDbContextModuleDescription(QLHDDbContextResources.CostTypePlural, "CostTypeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.CostTypes)),
                new QLHDDbContextModuleDescription(QLHDDbContextResources.ProjectPlural, "ProjectCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Projects)),
                new QLHDDbContextModuleDescription(QLHDDbContextResources.UserPlural, "UserCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Users)),
			};
        }
                	}

    public partial class QLHDDbContextModuleDescription : ModuleDescription<QLHDDbContextModuleDescription> {
        public QLHDDbContextModuleDescription(string title, string documentType, string group, Func<QLHDDbContextModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}