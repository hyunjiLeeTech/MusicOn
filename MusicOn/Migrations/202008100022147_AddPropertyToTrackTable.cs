namespace Assignment5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertyToTrackTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tracks", "ClipContentType", c => c.String());
            AddColumn("dbo.Tracks", "Clip", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tracks", "Clip");
            DropColumn("dbo.Tracks", "ClipContentType");
        }
    }
}
