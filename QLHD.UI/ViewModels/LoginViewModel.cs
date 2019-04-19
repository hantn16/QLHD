using QLHD.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.POCO;
using QLHD.Model;

namespace QLHD.UI.ViewModels
{
    public class LoginViewModel
    {
        QLHDDbContext dbContext = new QLHDDbContext();
        public List<string> LookUpUsers
        {
            get { return dbContext.Users.Select(x => x.Login).ToList(); }
        }
        public virtual User CurrentUser { get; set; }
        public bool IsCurrentUserCredentialsValid { get; private set; }
        // 
        [DevExpress.Mvvm.DataAnnotations.Command(false)]
        public void Init()
        {
            this.CurrentUser = new User();
        }
        public void Update()
        {
            IsCurrentUserCredentialsValid = dbContext.Users.Any(x => x.Login == CurrentUser.Login && x.Password == CurrentUser.Password);
        }
        public static LoginViewModel Create()
        {
            return ViewModelSource.Create<LoginViewModel>();
        }
    }
}
