namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Creatures", "Birthday", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Creatures", "Birthday", c => c.DateTime(nullable: false));
        }
    }
}
