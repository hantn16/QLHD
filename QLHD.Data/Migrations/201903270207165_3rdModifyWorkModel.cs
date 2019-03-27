namespace QLHD.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3rdModifyWorkModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Work", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Work", "Name", c => c.Int(nullable: false));
        }
    }
}
