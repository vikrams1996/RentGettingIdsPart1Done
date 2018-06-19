namespace mallform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAgainColoumnToTenant : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tenants", "brandName", c => c.String());
            AddColumn("dbo.Tenants", "Address", c => c.String());
            AddColumn("dbo.Tenants", "mobileNo", c => c.String());
            AddColumn("dbo.Tenants", "panNo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tenants", "panNo");
            DropColumn("dbo.Tenants", "mobileNo");
            DropColumn("dbo.Tenants", "Address");
            DropColumn("dbo.Tenants", "brandName");
        }
    }
}
