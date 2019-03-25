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

        public string Name { get; set; }

        public DateTime SigningDate { get; set; }

        public int WorkId { get; set; }

        [ForeignKey("WorkId")]
        public virtual Work Work { get; set; }

        public string Content { get; set; }

        public int ContractorId { get; set; }

        [ForeignKey("ContractorId")]
        public virtual Contractor Contractor { get; set; }

        public bool IsTerminated { get { return TerminateDate.HasValue; }}

        public DateTime? TerminateDate { get; set; }

        [DataType(DataType.Currency)]
        public double ContractOriginValue { get; set; }

        public virtual double ContractValue {
            get {
                return ContractOriginValue + ContractApendixes.Sum(x => x.Order);
            }
        }

        public virtual ICollection<ContractApendix> ContractApendixes { get; set; }

        public virtual ICollection<PaymentPeriod> PaymentPeriods { get; set; }
    }
}
