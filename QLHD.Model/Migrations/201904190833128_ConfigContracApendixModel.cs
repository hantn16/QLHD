namespace QLHD.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConfigContracApendixModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContractApendix", "Name", c => c.String());
            AddColumn("dbo.ContractApendix", "AdjustedValue", c => c.Double(nullable: false, defaultValue: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ContractApendix", "AdjustedValue");
            DropColumn("dbo.ContractApendix", "Name");
        }
    }
}
