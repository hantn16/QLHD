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
    [Table("Project")]
    public class Project : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(8)]
        [Display(Name ="Mã Dự Án")]
        public string Code { get; set; }

        [Display(Name = "Tên Dự Án")]
        public string Name { get; set; }

        [Display(Name = "Ngày Khởi Công")]
        public DateTime? StartDate { get; set; }

        [Display(Name = "Ngày Hoàn Công")]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Danh Sách Hạng Mục")]
        public virtual ICollection<Work> Works { get; set; }

        [Display(Name = "Danh Sách Hợp Đồng")]
        public virtual IEnumerable<Contract> Contracts {
            get {
                return Works.SelectMany(x => x.Contracts);
            }
        }

    }
}
