namespace QLHD.Model.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using QLHD.Model;
    using QLHD.Model.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<QLHDDbContext>
    {
        private QLHDDbContext _context { get; set; }
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            _context = new QLHDDbContext();
        }

        protected override void Seed(QLHDDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            Project[] projects = InitProject();
            if (context.Projects.Count() == 0)
            {
                context.Projects.AddRange(projects);
            }
            User[] users = InitUser();
            if (context.Users.Count() == 0)
            {
                context.Users.AddRange(users);
            }
            if (context.CostTypes.Count() == 0)
            {
                context.CostTypes.AddRange(InitCostType());
            }
            if (context.PaymentTypes.Count() == 0)
            {
                context.PaymentTypes.AddRange(InitPaymentType());
            }
            context.SaveChanges();

        }
        Project[] InitProject()
        {
            Project[] projects = new Project[]
            {
                new Project()
                {
                    Code = "DuAn01",
                    Name = "Xây dựng lại chung cư lô 4, lô 5 đường Trần Hưng Đạo",
                    IsActive = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "admin",
                    StartDate = new DateTime(2016,9,6)
                },
                new Project()
                {
                    Code = "DuAn02",
                    Name = "Khu đô thị tại phường Cao Thắng, Hà Khánh, Hà Lầm",
                    IsActive = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "admin",
                    StartDate = new DateTime(2016,9,6)
                }
            };
            return projects;
        }
        User[] InitUser()
        {
            User[] users = new User[] {
                new User(){Login = "Admin",Password = GetHash("admin")},
                new User(){Login = "Guest",Password = GetHash(null)},
                new User(){Login = "hantn",Password = GetHash("anhhan")},
            };
            return users;
        }
        CostType[] InitCostType()
        {
            return new CostType[]
            {
                new CostType() {Name = "Chi phí xây dựng",IsActive = true,CreatedAt = DateTime.Now,CreatedBy = "admin"},
                new CostType() {Name = "Chi phí thiết bị",IsActive = true,CreatedAt = DateTime.Now,CreatedBy = "admin"},
                new CostType() {Name = "Chi phí tư vấn, thiết kế",IsActive = true,CreatedAt = DateTime.Now,CreatedBy = "admin"},
                new CostType() {Name = "Chi phí GPMB",IsActive = true,CreatedAt = DateTime.Now,CreatedBy = "admin"},
                new CostType() {Name = "Chi phí QLDA",IsActive = true,CreatedAt = DateTime.Now,CreatedBy = "admin"},
                new CostType() {Name = "Chi phí bán hàng",IsActive = true,CreatedAt = DateTime.Now,CreatedBy = "admin"},
                new CostType() {Name = "Chi phí khác",IsActive = true,CreatedAt = DateTime.Now,CreatedBy = "admin"}
            };
        }

        PaymentType[] InitPaymentType()
        {
            return new PaymentType[]
            {
                new PaymentType(){Name = "Tạm ứng", IsActive = true, Description = "Ứng trước tiền cho nhà thầu cho dù họ chưa thi công",CreatedAt = DateTime.Now,CreatedBy = "admin"},
                new PaymentType(){Name = "Thanh toán", IsActive = true, Description = "Thanh toán tiền cho nhà thầu tương ứng với khối lượng nghiệm thu hoàn thành",CreatedAt = DateTime.Now,CreatedBy = "admin"},
                new PaymentType(){Name = "Quyết toán", IsActive = true, Description = "Thanh toán nốt tiền cho nhà thầu sau khi quyết toán khối lượng hoàn thành và thanh lý hợp đồng",CreatedAt = DateTime.Now,CreatedBy = "admin"}
            };
        }
        private string GetHash(string password)
        {
            return password;
        }
    }
}
