namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPrivilege : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Privileges",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        stonesNeeded = c.Short(nullable: false),
                        DurationOfPrivilege = c.Byte(nullable: false),
                        PrivilegeRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Creatures", "PrivilegeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Creatures", "PrivilegeId");
            AddForeignKey("dbo.Creatures", "PrivilegeId", "dbo.Privileges", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Creatures", "PrivilegeId", "dbo.Privileges");
            DropIndex("dbo.Creatures", new[] { "PrivilegeId" });
            DropColumn("dbo.Creatures", "PrivilegeId");
            DropTable("dbo.Privileges");
        }
    }
}
