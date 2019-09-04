namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTotalLoad : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Planets", "TotalLoad", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Planets", "TotalLoad");
        }
    }
}
