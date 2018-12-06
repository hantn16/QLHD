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
    [Table("ContractApendix")]
    public class ContractApendix : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Order { get; set; }

        public string Description { get; set; }

        [ForeignKey("Contract")]
        public int ContractId { get; set; }

        public virtual Contract Contract { get; set; }
    }
}
