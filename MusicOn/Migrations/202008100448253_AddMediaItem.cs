namespace Assignment5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMediaItem : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MediaItems", "Album_Id", "dbo.Albums");
            DropIndex("dbo.MediaItems", new[] { "Album_Id" });
            DropColumn("dbo.MediaItems", "Album_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MediaItems", "Album_Id", c => c.Int());
            CreateIndex("dbo.MediaItems", "Album_Id");
            AddForeignKey("dbo.MediaItems", "Album_Id", "dbo.Albums", "Id");
        }
    }
}
