namespace QLHD.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContractApendix",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Order = c.Int(nullable: false),
                        Description = c.String(),
                        ContractId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedAt = c.DateTime(),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contract", t => t.ContractId, cascadeDelete: true)
                .Index(t => t.ContractId);
            
            CreateTable(
                "dbo.Contract",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SigningDate = c.DateTime(nullable: false),
                        WorkId = c.Int(nullable: false),
                        Content = c.String(),
                        ContractorId = c.Int(nullable: false),
                        TerminateDate = c.DateTime(),
                        ContractOriginValue = c.Double(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedAt = c.DateTime(),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contractor", t => t.ContractorId, cascadeDelete: true)
                .ForeignKey("dbo.Work", t => t.WorkId, cascadeDelete: true)
                .Index(t => t.WorkId)
                .Index(t => t.ContractorId);
            
            CreateTable(
                "dbo.Contractor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 12),
                        Name = c.String(),
                        TaxCode = c.String(maxLength: 13),
                        Address = c.String(),
                        Representative = c.String(),
                        BankAccountNo = c.String(),
                        BankName = c.String(),
                        PhoneNumber = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedAt = c.DateTime(),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PaymentPeriod",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        ContractId = c.Int(nullable: false),
                        Order = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        ValueRequested = c.Double(nullable: false),
                        ValuePaid = c.Double(nullable: false),
                        ValueCompleted = c.Double(nullable: false),
                        ValueInInvoice = c.Double(nullable: false),
                        VatInInvoice = c.Double(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedAt = c.DateTime(),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contract", t => t.ContractId, cascadeDelete: true)
                .Index(t => t.ContractId);
            
            CreateTable(
                "dbo.Work",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        CostType = c.Int(nullable: false),
                        ProjectId = c.Int(nullable: false),
                        ParentWorkId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedAt = c.DateTime(),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Project", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId);
            
            CreateTable(
                "dbo.Project",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 8),
                        Name = c.String(),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedAt = c.DateTime(),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ContractApendix", "ContractId", "dbo.Contract");
            DropForeignKey("dbo.Work", "ProjectId", "dbo.Project");
            DropForeignKey("dbo.Contract", "WorkId", "dbo.Work");
            DropForeignKey("dbo.PaymentPeriod", "ContractId", "dbo.Contract");
            DropForeignKey("dbo.Contract", "ContractorId", "dbo.Contractor");
            DropIndex("dbo.Work", new[] { "ProjectId" });
            DropIndex("dbo.PaymentPeriod", new[] { "ContractId" });
            DropIndex("dbo.Contract", new[] { "ContractorId" });
            DropIndex("dbo.Contract", new[] { "WorkId" });
            DropIndex("dbo.ContractApendix", new[] { "ContractId" });
            DropTable("dbo.Project");
            DropTable("dbo.Work");
            DropTable("dbo.PaymentPeriod");
            DropTable("dbo.Contractor");
            DropTable("dbo.Contract");
            DropTable("dbo.ContractApendix");
        }
    }
}
