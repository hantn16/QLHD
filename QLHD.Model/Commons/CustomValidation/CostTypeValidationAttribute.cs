using QLHD.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHD.Model.Commons.CustomValidation
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Property,AllowMultiple = false,Inherited = true)]
    public class CostTypeValidationAttribute : ValidationAttribute
    {
        public static ValidationResult HasSameCostTypeWithParent(Work work)
        {
            var _context = new QLHDDbContext();
            if (work !=null && work.ParentWorkId != null)
            {
                Work parent = _context.Works.First(w => w.Id == work.ParentWorkId);
                if (parent != null && parent.CostTypeId != work.CostTypeId)
                {
                    return new ValidationResult("Hạng mục con phải cùng loại chi phí với hạng mục cha");
                }           
            }
            return ValidationResult.Success;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (validationContext == null)
            {
                return ValidationResult.Success;
            }
            //var _context = (QLHDDbContext) validationContext.GetService(typeof(QLHDDbContext))?? new QLHDDbContext();
            var _context = new QLHDDbContext();
            //var context = (QLHDDbContext) validationContext.ServiceContainer.GetService(typeof(QLHDDbContext));
            Work work = (Work)validationContext.ObjectInstance;
            var costTypeId = (int?)value;
            if (work.ParentWorkId == null)
            {
                return ValidationResult.Success;
            }
            else
            {
                Work parent = _context.Works.First(w => w.Id == work.ParentWorkId);
                if (costTypeId == parent.CostTypeId)
                {
                    return ValidationResult.Success;
                }
                //Work parentWork = context;
            }
            return new ValidationResult("Hạng mục con phải cùng loại chi phí với hạng mục cha");
        }
    }
}
