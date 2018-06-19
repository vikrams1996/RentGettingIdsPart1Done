namespace mallform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTenantWithShopName : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Tenants (shopName)VALUES ('Aldo')");
            Sql("INSERT INTO Tenants (shopName)VALUES ('Adidas')");
            Sql("INSERT INTO Tenants (shopName)VALUES ('FabIndia')");
            Sql("INSERT INTO Tenants (shopName)VALUES ('GAS')");
            Sql("INSERT INTO Tenants (shopName)VALUES ('Levis')");
            Sql("INSERT INTO Tenants (shopName)VALUES ('Lacoste')");
            Sql("INSERT INTO Tenants (shopName)VALUES ('Nike')");
            Sql("INSERT INTO Tenants (shopName)VALUES ('MAC')");
            Sql("INSERT INTO Tenants (shopName)VALUES ('Promod')");
            Sql("INSERT INTO Tenants (shopName)VALUES ('Tommy Hilfiger')");

        }

        public override void Down()
        {
        }
    }
}
