namespace mallform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class idk : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tenants", "shopName", c => c.String());
            DropColumn("dbo.Tenants", "brandName");
            DropColumn("dbo.Tenants", "Address");
            DropColumn("dbo.Tenants", "mobileNo");
            DropColumn("dbo.Tenants", "panNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tenants", "panNo", c => c.String());
            AddColumn("dbo.Tenants", "mobileNo", c => c.String(nullable: false));
            AddColumn("dbo.Tenants", "Address", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Tenants", "brandName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Tenants", "shopName", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
