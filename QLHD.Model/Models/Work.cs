using QLHD.Model.Abstracts;
using QLHD.Model.Commons.CustomValidation;
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
    [CustomValidation(typeof(CostTypeValidationAttribute), "HasSameCostTypeWithParent")]
    public class Work : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(AutoGenerateField = false)]
        public int Id { get; set; }

        [Display(Name = "Tên Hạng Mục")]
        public string Name { get; set; }

        [Display(Name = "Mã loại chi phí")]
        public int CostTypeId { get; set; }

        [Display(Name = "Loại Chi Phí")]
        [ForeignKey("CostTypeId")]
        public virtual CostType CostType { get; set; }

        [Display(Name = "Mã Dự Án")]
        [ProjectValidationAttribute]
        public int ProjectId { get; set; }

        [Display(Name = "Dự Án")]
        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }

        [Display(Name = "Mã Hạng Mục Cha")]
        public int? ParentWorkId { get; set; }

        [Display(Name = "Hạng Mục Cha")]
        [ForeignKey("ParentWorkId")]
        public virtual Work ParentWork { get; set; }

        [Display(Name = "DS Hạng Mục Con")]
        public virtual ICollection<Work> ChildWorks { get; set; }

        [Display(Name = "Danh Sách Hợp Đồng")]
        public virtual ICollection<Contract> Contracts { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

}
