namespace Assignment5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertyAndMediaItemTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MediaItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Timestamp = c.DateTime(nullable: false),
                        StringId = c.String(nullable: false, maxLength: 100),
                        Content = c.Binary(),
                        ContentType = c.String(maxLength: 200),
                        Caption = c.String(nullable: false, maxLength: 100),
                        Artist_Id = c.Int(nullable: false),
                        Album_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Artists", t => t.Artist_Id)
                .ForeignKey("dbo.Albums", t => t.Album_Id)
                .Index(t => t.Artist_Id)
                .Index(t => t.Album_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MediaItems", "Album_Id", "dbo.Albums");
            DropForeignKey("dbo.MediaItems", "Artist_Id", "dbo.Artists");
            DropIndex("dbo.MediaItems", new[] { "Album_Id" });
            DropIndex("dbo.MediaItems", new[] { "Artist_Id" });
            DropTable("dbo.MediaItems");
        }
    }
}
