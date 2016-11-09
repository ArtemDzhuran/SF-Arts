namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedpropertynameImageUritoImageURL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "ImageURL", c => c.String());
            DropColumn("dbo.Posts", "ImageUri");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "ImageUri", c => c.String());
            DropColumn("dbo.Posts", "ImageURL");
        }
    }
}
