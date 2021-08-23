using DevExpress.Mvvm.DataAnnotations;
using QLHD.Model;
using QLHD.Model.Models;
using QLHD.UI.Localization;

namespace QLHD.UI.QLHDDbContextDataModel {

    public class QLHDDbContextMetadataProvider {
		        public static void BuildMetadata(MetadataBuilder<ContractApendix> builder) {
			builder.DisplayName(QLHDDbContextResources.ContractApendix);
						builder.Property(x => x.Order).DisplayName(QLHDDbContextResources.ContractApendix_Order);
						builder.Property(x => x.Name).DisplayName(QLHDDbContextResources.ContractApendix_Name);
						builder.Property(x => x.Description).DisplayName(QLHDDbContextResources.ContractApendix_Description);
						builder.Property(x => x.AdjustedValue).DisplayName(QLHDDbContextResources.ContractApendix_AdjustedValue);
						builder.Property(x => x.IsActive).DisplayName(QLHDDbContextResources.ContractApendix_IsActive);
						builder.Property(x => x.CreatedAt).DisplayName(QLHDDbContextResources.ContractApendix_CreatedAt);
						builder.Property(x => x.CreatedBy).DisplayName(QLHDDbContextResources.ContractApendix_CreatedBy);
						builder.Property(x => x.ModifiedAt).DisplayName(QLHDDbContextResources.ContractApendix_ModifiedAt);
						builder.Property(x => x.ModifiedBy).DisplayName(QLHDDbContextResources.ContractApendix_ModifiedBy);
						builder.Property(x => x.Contract).DisplayName(QLHDDbContextResources.ContractApendix_Contract);
			        }
		        public static void BuildMetadata(MetadataBuilder<Contract> builder) {
			builder.DisplayName(QLHDDbContextResources.Contract);
						builder.Property(x => x.Name).DisplayName(QLHDDbContextResources.Contract_Name);
						builder.Property(x => x.SigningDate).DisplayName(QLHDDbContextResources.Contract_SigningDate);
						builder.Property(x => x.Content).DisplayName(QLHDDbContextResources.Contract_Content);
						builder.Property(x => x.TerminateDate).DisplayName(QLHDDbContextResources.Contract_TerminateDate);
						builder.Property(x => x.ContractOriginValue).DisplayName(QLHDDbContextResources.Contract_ContractOriginValue);
						builder.Property(x => x.IsActive).DisplayName(QLHDDbContextResources.Contract_IsActive);
						builder.Property(x => x.CreatedAt).DisplayName(QLHDDbContextResources.Contract_CreatedAt);
						builder.Property(x => x.CreatedBy).DisplayName(QLHDDbContextResources.Contract_CreatedBy);
						builder.Property(x => x.ModifiedAt).DisplayName(QLHDDbContextResources.Contract_ModifiedAt);
						builder.Property(x => x.ModifiedBy).DisplayName(QLHDDbContextResources.Contract_ModifiedBy);
						builder.Property(x => x.Contractor).DisplayName(QLHDDbContextResources.Contract_Contractor);
						builder.Property(x => x.Work).DisplayName(QLHDDbContextResources.Contract_Work);
			        }
		        public static void BuildMetadata(MetadataBuilder<Contractor> builder) {
			builder.DisplayName(QLHDDbContextResources.Contractor);
						builder.Property(x => x.Code).DisplayName(QLHDDbContextResources.Contractor_Code);
						builder.Property(x => x.Name).DisplayName(QLHDDbContextResources.Contractor_Name);
						builder.Property(x => x.TaxCode).DisplayName(QLHDDbContextResources.Contractor_TaxCode);
						builder.Property(x => x.Address).DisplayName(QLHDDbContextResources.Contractor_Address);
						builder.Property(x => x.Representative).DisplayName(QLHDDbContextResources.Contractor_Representative);
						builder.Property(x => x.BankAccountNo).DisplayName(QLHDDbContextResources.Contractor_BankAccountNo);
						builder.Property(x => x.BankName).DisplayName(QLHDDbContextResources.Contractor_BankName);
						builder.Property(x => x.PhoneNumber).DisplayName(QLHDDbContextResources.Contractor_PhoneNumber);
						builder.Property(x => x.IsActive).DisplayName(QLHDDbContextResources.Contractor_IsActive);
						builder.Property(x => x.CreatedAt).DisplayName(QLHDDbContextResources.Contractor_CreatedAt);
						builder.Property(x => x.CreatedBy).DisplayName(QLHDDbContextResources.Contractor_CreatedBy);
						builder.Property(x => x.ModifiedAt).DisplayName(QLHDDbContextResources.Contractor_ModifiedAt);
						builder.Property(x => x.ModifiedBy).DisplayName(QLHDDbContextResources.Contractor_ModifiedBy);
			        }
		        public static void BuildMetadata(MetadataBuilder<PaymentPeriod> builder) {
			builder.DisplayName(QLHDDbContextResources.PaymentPeriod);
						builder.Property(x => x.Name).DisplayName(QLHDDbContextResources.PaymentPeriod_Name);
						builder.Property(x => x.Description).DisplayName(QLHDDbContextResources.PaymentPeriod_Description);
						builder.Property(x => x.Order).DisplayName(QLHDDbContextResources.PaymentPeriod_Order);
						builder.Property(x => x.ValueRequested).DisplayName(QLHDDbContextResources.PaymentPeriod_ValueRequested);
						builder.Property(x => x.RequestedDate).DisplayName(QLHDDbContextResources.PaymentPeriod_RequestedDate);
						builder.Property(x => x.ValuePaid).DisplayName(QLHDDbContextResources.PaymentPeriod_ValuePaid);
						builder.Property(x => x.PaidDate).DisplayName(QLHDDbContextResources.PaymentPeriod_PaidDate);
						builder.Property(x => x.ValueAccepted).DisplayName(QLHDDbContextResources.PaymentPeriod_ValueAccepted);
						builder.Property(x => x.AcceptedDate).DisplayName(QLHDDbContextResources.PaymentPeriod_AcceptedDate);
						builder.Property(x => x.IsActive).DisplayName(QLHDDbContextResources.PaymentPeriod_IsActive);
						builder.Property(x => x.CreatedAt).DisplayName(QLHDDbContextResources.PaymentPeriod_CreatedAt);
						builder.Property(x => x.CreatedBy).DisplayName(QLHDDbContextResources.PaymentPeriod_CreatedBy);
						builder.Property(x => x.ModifiedAt).DisplayName(QLHDDbContextResources.PaymentPeriod_ModifiedAt);
						builder.Property(x => x.ModifiedBy).DisplayName(QLHDDbContextResources.PaymentPeriod_ModifiedBy);
						builder.Property(x => x.Contract).DisplayName(QLHDDbContextResources.PaymentPeriod_Contract);
						builder.Property(x => x.PaymentType).DisplayName(QLHDDbContextResources.PaymentPeriod_PaymentType);
			        }
		        public static void BuildMetadata(MetadataBuilder<Invoice> builder) {
			builder.DisplayName(QLHDDbContextResources.Invoice);
						builder.Property(x => x.Number).DisplayName(QLHDDbContextResources.Invoice_Number);
						builder.Property(x => x.ReleaseDate).DisplayName(QLHDDbContextResources.Invoice_ReleaseDate);
						builder.Property(x => x.PretaxValue).DisplayName(QLHDDbContextResources.Invoice_PretaxValue);
						builder.Property(x => x.VatValue).DisplayName(QLHDDbContextResources.Invoice_VatValue);
						builder.Property(x => x.IsActive).DisplayName(QLHDDbContextResources.Invoice_IsActive);
						builder.Property(x => x.CreatedAt).DisplayName(QLHDDbContextResources.Invoice_CreatedAt);
						builder.Property(x => x.CreatedBy).DisplayName(QLHDDbContextResources.Invoice_CreatedBy);
						builder.Property(x => x.ModifiedAt).DisplayName(QLHDDbContextResources.Invoice_ModifiedAt);
						builder.Property(x => x.ModifiedBy).DisplayName(QLHDDbContextResources.Invoice_ModifiedBy);
						builder.Property(x => x.PaymentPeriod).DisplayName(QLHDDbContextResources.Invoice_PaymentPeriod);
			        }
		        public static void BuildMetadata(MetadataBuilder<PaymentType> builder) {
			builder.DisplayName(QLHDDbContextResources.PaymentType);
						builder.Property(x => x.Name).DisplayName(QLHDDbContextResources.PaymentType_Name);
						builder.Property(x => x.Description).DisplayName(QLHDDbContextResources.PaymentType_Description);
						builder.Property(x => x.IsActive).DisplayName(QLHDDbContextResources.PaymentType_IsActive);
						builder.Property(x => x.CreatedAt).DisplayName(QLHDDbContextResources.PaymentType_CreatedAt);
						builder.Property(x => x.CreatedBy).DisplayName(QLHDDbContextResources.PaymentType_CreatedBy);
						builder.Property(x => x.ModifiedAt).DisplayName(QLHDDbContextResources.PaymentType_ModifiedAt);
						builder.Property(x => x.ModifiedBy).DisplayName(QLHDDbContextResources.PaymentType_ModifiedBy);
			        }
		        public static void BuildMetadata(MetadataBuilder<Work> builder) {
			builder.DisplayName(QLHDDbContextResources.Work);
						builder.Property(x => x.Name).DisplayName(QLHDDbContextResources.Work_Name);
						builder.Property(x => x.IsActive).DisplayName(QLHDDbContextResources.Work_IsActive);
						builder.Property(x => x.CreatedAt).DisplayName(QLHDDbContextResources.Work_CreatedAt);
						builder.Property(x => x.CreatedBy).DisplayName(QLHDDbContextResources.Work_CreatedBy);
						builder.Property(x => x.ModifiedAt).DisplayName(QLHDDbContextResources.Work_ModifiedAt);
						builder.Property(x => x.ModifiedBy).DisplayName(QLHDDbContextResources.Work_ModifiedBy);
						builder.Property(x => x.CostType).DisplayName(QLHDDbContextResources.Work_CostType);
						builder.Property(x => x.ParentWork).DisplayName(QLHDDbContextResources.Work_ParentWork);
						builder.Property(x => x.Project).DisplayName(QLHDDbContextResources.Work_Project);
			        }
		        public static void BuildMetadata(MetadataBuilder<CostType> builder) {
			builder.DisplayName(QLHDDbContextResources.CostType);
						builder.Property(x => x.Id).DisplayName(QLHDDbContextResources.CostType_Id);
						builder.Property(x => x.Name).DisplayName(QLHDDbContextResources.CostType_Name);
						builder.Property(x => x.IsActive).DisplayName(QLHDDbContextResources.CostType_IsActive);
						builder.Property(x => x.CreatedAt).DisplayName(QLHDDbContextResources.CostType_CreatedAt);
						builder.Property(x => x.CreatedBy).DisplayName(QLHDDbContextResources.CostType_CreatedBy);
						builder.Property(x => x.ModifiedAt).DisplayName(QLHDDbContextResources.CostType_ModifiedAt);
						builder.Property(x => x.ModifiedBy).DisplayName(QLHDDbContextResources.CostType_ModifiedBy);
			        }
		        public static void BuildMetadata(MetadataBuilder<Project> builder) {
			builder.DisplayName(QLHDDbContextResources.Project);
						builder.Property(x => x.Code).DisplayName(QLHDDbContextResources.Project_Code);
						builder.Property(x => x.Name).DisplayName(QLHDDbContextResources.Project_Name);
						builder.Property(x => x.StartDate).DisplayName(QLHDDbContextResources.Project_StartDate);
						builder.Property(x => x.EndDate).DisplayName(QLHDDbContextResources.Project_EndDate);
						builder.Property(x => x.IsActive).DisplayName(QLHDDbContextResources.Project_IsActive);
						builder.Property(x => x.CreatedAt).DisplayName(QLHDDbContextResources.Project_CreatedAt);
						builder.Property(x => x.CreatedBy).DisplayName(QLHDDbContextResources.Project_CreatedBy);
						builder.Property(x => x.ModifiedAt).DisplayName(QLHDDbContextResources.Project_ModifiedAt);
						builder.Property(x => x.ModifiedBy).DisplayName(QLHDDbContextResources.Project_ModifiedBy);
			        }
		        public static void BuildMetadata(MetadataBuilder<User> builder) {
			builder.DisplayName(QLHDDbContextResources.User);
						builder.Property(x => x.Login).DisplayName(QLHDDbContextResources.User_Login);
						builder.Property(x => x.Password).DisplayName(QLHDDbContextResources.User_Password);
			        }
		    }
}