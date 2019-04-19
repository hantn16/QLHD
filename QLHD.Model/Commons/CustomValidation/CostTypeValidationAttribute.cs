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
            if (work.ParentWorkId == null)
            {
                return ValidationResult.Success;
            }
            else
            {

            }
            return new ValidationResult("Hạng mục con phải thuộc loại chi phí giống hạng mục cha");
        }
        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            var work = (Work)value;
            Type myType = context.GetType();
            var _context = context.GetService(myType);
            if (work.ParentWorkId == null)
            {
                return ValidationResult.Success;
            }
            else
            {
                //Work parentWork = context;
            }
            return new ValidationResult("Test");
        }
    }
}
