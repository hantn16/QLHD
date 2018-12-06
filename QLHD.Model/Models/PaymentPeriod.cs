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
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int ContractId { get; set; }

        [ForeignKey("ContractId")]
        public virtual Contract Contract { get; set; }

        public int Order { get; set; }

        public PaymentType Type { get; set; }

        public double ValueRequested { get; set; }

        public double ValuePaid { get; set; }

        public double ValueCompleted { get; set; }

        public double ValueInInvoice { get; set; }

        public double VatInInvoice { get; set; }
    }
    public enum PaymentType
    {
        Advanced = 0,
        PaidInProgress = 1,
        Settlement = 2
    }
}
