using QLHD.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHD.Model.Commons.CustomValidation
{
    public class ProjectValidationAttribute : ValidationAttribute
    {
        /// <summary>
        /// Hàm kiểm tra xem mã dự án của hạng mục con có giống với mã dự án của hạng mục cha
        /// </summary>
        /// <param name="value"></param>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (validationContext != null)
            {
                var _context = new QLHDDbContext();
                Work work = (Work)validationContext.ObjectInstance;
                var projectId = (int?)value;
                if (work.ParentWorkId != null)
                {
                    Work parent = _context.Works.First(w => w.Id == work.ParentWorkId);
                    if (projectId != parent.ProjectId)
                    {
                        return new ValidationResult("Hạng mục con phải cùng dự án với hạng mục cha");
                    }
                }             
            }
            return ValidationResult.Success;
        }
    }
}
