namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Planets", "TypeId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Planets", "TypeId");
        }
    }
}
