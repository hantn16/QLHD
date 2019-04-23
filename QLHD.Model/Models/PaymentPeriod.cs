using QLHD.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHD.Model.Models
{
    [Table("PaymentPeriod")]
    public class PaymentPeriod : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(AutoGenerateField = false)]
        public int Id { get; set; }

        [Display(Name = "Tên Lần TT")]
        public string Name { get; set; }

        [Display(Name = "Mô Tả")]
        public string Description { get; set; }

        [Display(Name = "Mã Hợp Đồng")]
        public int ContractId { get; set; }

        [Display(Name = "Hợp Đồng")]
        [ForeignKey("ContractId")]
        public virtual Contract Contract { get; set; }

        [Display(Name = "Thứ Tự")]
        public int Order { get; set; }

        [Display(Name = "Mã Kiểu TT")]
        public int PaymentTypeId { get; set; }

        [Display(Name = "Kiểu TT")]
        [ForeignKey("PaymentTypeId")]
        public virtual PaymentType PaymentType { get; set; }

        [Display(Name = "Số Tiền Đề Nghị")]
        public double ValueRequested { get; set; }

        [Display(Name = "Ngày Đề Nghị")]
        public DateTime RequestedDate { get; set; }

        [Display(Name = "Số Tiền Thanh Toán")]
        public double ValuePaid { get; set; }

        [Display(Name = "Ngày Thanh Toán")]
        public DateTime PaidDate { get; set; }

        [Display(Name = "Giá Trị NTHT")]
        public double ValueAccepted { get; set; }

        [Display(Name = "Ngày nghiệm thu")]
        public DateTime? AcceptedDate { get; set; }

        [Display(Name = "Mã Hóa Đơn")]
        public int? InvoiceId { get; set; }

        [Display(Name = "Hóa Đơn")]
        public virtual Invoice Invoice { get; set; }
    }

}
