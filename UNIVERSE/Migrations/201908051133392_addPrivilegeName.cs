namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPrivilegeName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Privileges", "privilegenName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Privileges", "privilegenName");
        }
    }
}
