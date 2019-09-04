namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    //sorry I given the wrong name, this is try to remove the default value.
    public partial class tryRemoveNullable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Creatures", "Birthddate", c => c.DateTime());
            DropColumn("dbo.Creatures", "Birthday");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Creatures", "Birthday", c => c.DateTime());
            DropColumn("dbo.Creatures", "Birthddate");
        }
    }
}
