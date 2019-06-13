namespace QLHD.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class configContractor : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contractor", "Code", c => c.String(maxLength: 16));
            AlterColumn("dbo.Contractor", "TaxCode", c => c.String(maxLength: 14));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contractor", "TaxCode", c => c.String(maxLength: 13));
            AlterColumn("dbo.Contractor", "Code", c => c.String(maxLength: 12));
        }
    }
}
