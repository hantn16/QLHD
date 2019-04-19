namespace QLHD.Data
{
    using QLHD.Model.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class QLHDDbContext : DbContext
    {
        // Your context has been configured to use a 'QLHDDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'QLHD.Data.QLHDDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QLHDDbContext' 
        // connection string in the application configuration file.
        public QLHDDbContext()
            : base("name=QLHDDbContext")
        {
            this.Configuration.LazyLoadingEnabled = true;
            Database.SetInitializer<QLHDDbContext>(new DropCreateDatabaseIfModelChanges<QLHDDbContext>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<ContractApendix> ContractApendixes { get; set; }
        public virtual DbSet<Contractor> Contractors { get; set; }
        public virtual DbSet<PaymentPeriod> PaymentPeriods { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Work> Works { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<CostType> CostTypes { get; set; }

    }


    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}