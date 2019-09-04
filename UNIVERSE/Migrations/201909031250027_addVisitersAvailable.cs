namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addVisitersAvailable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Planets", "VisitersAvailable", c => c.Byte(nullable: false));
            Sql("UPDATE Planets SET VisitersAvailable = TotalLoad");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Planets", "VisitersAvailable");
        }
    }
}
