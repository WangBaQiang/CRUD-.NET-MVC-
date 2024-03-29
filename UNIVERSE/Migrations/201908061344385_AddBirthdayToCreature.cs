namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdayToCreature : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Creatures", "Birthday", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Creatures", "Birthday");
        }
    }
}
