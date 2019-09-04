namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeTypo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Creatures", "Birthdate", c => c.DateTime());
            DropColumn("dbo.Creatures", "Birthddate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Creatures", "Birthddate", c => c.DateTime());
            DropColumn("dbo.Creatures", "Birthdate");
        }
    }
}
