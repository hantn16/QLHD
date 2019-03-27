namespace QLHD.Data.Migrations
{
    using QLHD.Model.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QLHD.Data.QLHDDbContext>
    {
        private QLHDDbContext _context { get; set; }
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            _context = new QLHDDbContext();
        }

        protected override void Seed(QLHD.Data.QLHDDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            Project[] projects = InitProject();
            if (context.Projects.Count()==0)
            {
                context.Projects.AddRange(projects);
            }           
            User[] users = InitUser();
            if (context.Users.Count() == 0)
            {
                context.Users.AddRange(users);
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
        private string GetHash(string password)
        {
            return password;
        }
    }
}
