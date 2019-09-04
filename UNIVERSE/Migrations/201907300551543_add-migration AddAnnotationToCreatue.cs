namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationAddAnnotationToCreatue : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Creatures", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Creatures", "Name", c => c.String());
        }
    }
}
