namespace mallform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Units", "Name", c => c.String());
            DropColumn("dbo.Units", "Size");
            DropColumn("dbo.Units", "Floor");
            DropColumn("dbo.Units", "shopNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Units", "shopNo", c => c.String());
            AddColumn("dbo.Units", "Floor", c => c.String());
            AddColumn("dbo.Units", "Size", c => c.String());
            DropColumn("dbo.Units", "Name");
        }
    }
}
