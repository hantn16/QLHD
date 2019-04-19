namespace QLHD.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Config_Work_Model : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Work", "ParentWorkId");
            AddForeignKey("dbo.Work", "ParentWorkId", "dbo.Work", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Work", "ParentWorkId", "dbo.Work");
            DropIndex("dbo.Work", new[] { "ParentWorkId" });
        }
    }
}
