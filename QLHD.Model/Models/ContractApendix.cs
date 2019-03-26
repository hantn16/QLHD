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

        [Display(Name = "Thứ Tự")]
        public int Order { get; set; }

        [Display(Name = "Tên Phụ Lục")]
        public string Description { get; set; }

        [Display(Name = "Mã Hợp Đồng")]
        [ForeignKey("Contract")]
        public int ContractId { get; set; }

        [Display(Name = "Hợp Đồng")]
        public virtual Contract Contract { get; set; }
    }
}
