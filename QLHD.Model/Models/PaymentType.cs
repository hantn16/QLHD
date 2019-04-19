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
    [Table("PaymentType")]
    public class PaymentType : Auditable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(AutoGenerateField = false)]
        public int Id { get; set; }

        [Display(Name = "Kiểu Thanh Toán")]
        public string Name { get; set; }

        [Display(Name = "Mô tả")]
        public string Description { get; set; }

        public virtual ICollection<PaymentPeriod> PaymentPeriods { get; set; }
    }
    //public enum PaymentType
    //{
    //    Advanced = 0,
    //    PaidInProgress = 1,
    //    Settlement = 2
    //}
}
