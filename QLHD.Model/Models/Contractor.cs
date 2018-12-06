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
    [Table("Contractor")]
    public class Contractor : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MinLength(4)]
        [MaxLength(12)]
        public string Code { get; set; }

        public string Name { get; set; }

        [MinLength(10)]
        [MaxLength(13)]
        public string TaxCode { get; set; }

        public string Address { get; set; }

        public string Representative { get; set; }

        public string BankAccountNo { get; set; }

        public string BankName { get; set; }

        public string PhoneNumber { get; set; }

        public virtual ICollection<Contract> Contracts { get; set; }


    }
}
