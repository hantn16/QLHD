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
            Project project = new Project()
            {
                Id = 1,
                Code = "DuAn01",
                Name = "Xây dựng lại chung cư lô 4, lô 5 đường Trần Hưng Đạo",
                CreatedAt = DateTime.Now,
                CreatedBy = "admin",
                StartDate = new DateTime(2016,9,6)
            };
            context.Projects.Add(project);
            context.SaveChanges();
            
        }
    }
}
