namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makeNameNotnullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Planets", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Planets", "Name", c => c.String());
        }
    }
}
