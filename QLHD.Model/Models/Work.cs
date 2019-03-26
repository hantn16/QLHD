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
    [Table("Work")]
    public class Work : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Tên Hạng Mục")]
        public int Name { get; set; }

        [Display(Name = "Loại Chi Phí")]
        public int CostType { get; set; }

        [Display(Name = "Mã Dự Án")]
        public int ProjectId { get; set; }

        [Display(Name = "Dự Án")]
        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }

        [Display(Name = "Hạng Mục Cha")]
        public int? ParentWorkId { get; set; }

        [Display(Name = "Danh Sách Hợp Đồng")]
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
