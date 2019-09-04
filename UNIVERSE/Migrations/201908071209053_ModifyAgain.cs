namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyAgain : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Planets", "TypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Planets", "TypeId", c => c.Byte(nullable: false));
        }
    }
}
