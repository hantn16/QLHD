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
    [Table("Contract")]
    public class Contract : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Tên Hợp Đồng")]
        public string Name { get; set; }

        [Display(Name = "Ngày ký")]
        public DateTime SigningDate { get; set; }

        [Display(Name = "Mã Hạng Mục")]
        public int WorkId { get; set; }

        [Display(Name = "Hạng Mục")]
        [ForeignKey("WorkId")]
        public virtual Work Work { get; set; }

        [Display(Name = "Nội Dung")]
        public string Content { get; set; }

        [Display(Name = "Mã Nhà Thầu")]
        public int ContractorId { get; set; }

        [Display(Name = "Nhà Thầu")]
        [ForeignKey("ContractorId")]
        public virtual Contractor Contractor { get; set; }

        [Display(Name = "Đã Thanh Lý")]
        public bool IsTerminated { get { return TerminateDate.HasValue; }}

        [Display(Name = "Ngày Thanh Lý")]
        public DateTime? TerminateDate { get; set; }

        [Display(Name = "GTHĐ Ban Đầu")]
        [DataType(DataType.Currency)]
        public double ContractOriginValue { get; set; }

        [Display(Name = "GTHĐ Hiện Tại")]
        public virtual double ContractValue {
            get {
                return ContractOriginValue + ContractApendixes.Sum(x => x.Order);
            }
        }

        [Display(Name = "Danh Sách Phụ Lục")]
        public virtual ICollection<ContractApendix> ContractApendixes { get; set; }

        [Display(Name = "Danh Sách Lần Thanh Toán")]
        public virtual ICollection<PaymentPeriod> PaymentPeriods { get; set; }
    }
}
