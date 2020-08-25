namespace Assignment5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Recover : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MediaItems", "Album_Id", c => c.Int());
            CreateIndex("dbo.MediaItems", "Album_Id");
            AddForeignKey("dbo.MediaItems", "Album_Id", "dbo.Albums", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MediaItems", "Album_Id", "dbo.Albums");
            DropIndex("dbo.MediaItems", new[] { "Album_Id" });
            DropColumn("dbo.MediaItems", "Album_Id");
        }
    }
}
