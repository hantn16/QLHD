namespace QLHD.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCostTypeAndPaymentTypeModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PaymentType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedAt = c.DateTime(),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CostType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedAt = c.DateTime(),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.PaymentPeriod", "PaymentTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.Work", "CostTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.PaymentPeriod", "PaymentTypeId");
            CreateIndex("dbo.Work", "CostTypeId");
            AddForeignKey("dbo.PaymentPeriod", "PaymentTypeId", "dbo.PaymentType", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Work", "CostTypeId", "dbo.CostType", "Id", cascadeDelete: true);
            DropColumn("dbo.PaymentPeriod", "Type");
            DropColumn("dbo.Work", "CostType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Work", "CostType", c => c.Int(nullable: false));
            AddColumn("dbo.PaymentPeriod", "Type", c => c.Int(nullable: false));
            DropForeignKey("dbo.Work", "CostTypeId", "dbo.CostType");
            DropForeignKey("dbo.PaymentPeriod", "PaymentTypeId", "dbo.PaymentType");
            DropIndex("dbo.Work", new[] { "CostTypeId" });
            DropIndex("dbo.PaymentPeriod", new[] { "PaymentTypeId" });
            DropColumn("dbo.Work", "CostTypeId");
            DropColumn("dbo.PaymentPeriod", "PaymentTypeId");
            DropTable("dbo.CostType");
            DropTable("dbo.PaymentType");
        }
    }
}
