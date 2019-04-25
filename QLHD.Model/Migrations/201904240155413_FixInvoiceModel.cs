namespace QLHD.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixInvoiceModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Invoice", "Id", "dbo.PaymentPeriod");
            DropIndex("dbo.Invoice", new[] { "Id" });
            AddColumn("dbo.Invoice", "PaymentPeriodId", c => c.Int(nullable: false));
            CreateIndex("dbo.Invoice", "PaymentPeriodId");
            AddForeignKey("dbo.Invoice", "PaymentPeriodId", "dbo.PaymentPeriod", "Id", cascadeDelete: true);
            DropColumn("dbo.PaymentPeriod", "InvoiceId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PaymentPeriod", "InvoiceId", c => c.Int());
            DropForeignKey("dbo.Invoice", "PaymentPeriodId", "dbo.PaymentPeriod");
            DropIndex("dbo.Invoice", new[] { "PaymentPeriodId" });
            DropColumn("dbo.Invoice", "PaymentPeriodId");
            CreateIndex("dbo.Invoice", "Id");
            AddForeignKey("dbo.Invoice", "Id", "dbo.PaymentPeriod", "Id");
        }
    }
}
