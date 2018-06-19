namespace mallform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FloorAndSizeAddedToUnit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Units", "Floor", c => c.String());
            AddColumn("dbo.Units", "Size", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Units", "Size");
            DropColumn("dbo.Units", "Floor");
        }
    }
}
