namespace mallform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColoumnsToTenants : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tenants", "brandName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Tenants", "Address", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Tenants", "mobileNo", c => c.String(nullable: false));
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
