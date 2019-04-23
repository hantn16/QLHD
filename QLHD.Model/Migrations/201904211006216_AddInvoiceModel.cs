namespace QLHD.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInvoiceModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Invoice",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(maxLength: 7),
                        ReleaseDate = c.DateTime(nullable: false),
                        PretaxValue = c.Double(nullable: false),
                        VatValue = c.Double(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedAt = c.DateTime(),
                        ModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PaymentPeriod", t => t.Id)
                .Index(t => t.Id);
            
            AddColumn("dbo.PaymentPeriod", "RequestedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.PaymentPeriod", "PaidDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.PaymentPeriod", "ValueAccepted", c => c.Double(nullable: false));
            AddColumn("dbo.PaymentPeriod", "AcceptedDate", c => c.DateTime());
            AddColumn("dbo.PaymentPeriod", "InvoiceId", c => c.Int());
            DropColumn("dbo.PaymentPeriod", "ValueCompleted");
            DropColumn("dbo.PaymentPeriod", "ValueInInvoice");
            DropColumn("dbo.PaymentPeriod", "VatInInvoice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PaymentPeriod", "VatInInvoice", c => c.Double(nullable: false));
            AddColumn("dbo.PaymentPeriod", "ValueInInvoice", c => c.Double(nullable: false));
            AddColumn("dbo.PaymentPeriod", "ValueCompleted", c => c.Double(nullable: false));
            DropForeignKey("dbo.Invoice", "Id", "dbo.PaymentPeriod");
            DropIndex("dbo.Invoice", new[] { "Id" });
            DropColumn("dbo.PaymentPeriod", "InvoiceId");
            DropColumn("dbo.PaymentPeriod", "AcceptedDate");
            DropColumn("dbo.PaymentPeriod", "ValueAccepted");
            DropColumn("dbo.PaymentPeriod", "PaidDate");
            DropColumn("dbo.PaymentPeriod", "RequestedDate");
            DropTable("dbo.Invoice");
        }
    }
}
