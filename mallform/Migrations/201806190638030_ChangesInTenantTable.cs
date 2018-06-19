namespace mallform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesInTenantTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tenants", "brandName");
            DropColumn("dbo.Tenants", "Address");
            DropColumn("dbo.Tenants", "mobileNo");
            DropColumn("dbo.Tenants", "panNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tenants", "panNo", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Tenants", "mobileNo", c => c.String(nullable: false));
            AddColumn("dbo.Tenants", "Address", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Tenants", "brandName", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
