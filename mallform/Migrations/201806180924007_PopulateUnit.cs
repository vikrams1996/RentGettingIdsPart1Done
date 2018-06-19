namespace mallform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateUnit : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Units (shopNo) VALUES ('1A')");
            Sql("INSERT INTO Units (shopNo) VALUES ('1B')");
            Sql("INSERT INTO Units (shopNo) VALUES ('1C')");
            Sql("INSERT INTO Units (shopNo) VALUES ('2A')");
            Sql("INSERT INTO Units (shopNo) VALUES ('2B')");
            Sql("INSERT INTO Units (shopNo) VALUES ('2C')");
            Sql("INSERT INTO Units (shopNo) VALUES ('3A')");
            Sql("INSERT INTO Units (shopNo) VALUES ('3B')");
            Sql("INSERT INTO Units (shopNo) VALUES ('3C')");

        }
        
        public override void Down()
        {
        }
    }
}
