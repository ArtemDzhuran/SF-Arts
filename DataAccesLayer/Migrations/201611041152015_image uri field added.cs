namespace SFArts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imageurifieldadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "ImageUri", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "ImageUri");
        }
    }
}
