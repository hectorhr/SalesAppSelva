namespace ProductSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "Image", c => c.Binary(storeType: "image"));
            AddColumn("dbo.Product", "DisplayItem", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "DisplayItem");
            DropColumn("dbo.Product", "Image");
        }
    }
}
