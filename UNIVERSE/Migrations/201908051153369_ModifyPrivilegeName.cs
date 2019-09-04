namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyPrivilegeName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Privileges", "privilegeName", c => c.String());
            DropColumn("dbo.Privileges", "privilegenName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Privileges", "privilegenName", c => c.String());
            DropColumn("dbo.Privileges", "privilegeName");
        }
    }
}
