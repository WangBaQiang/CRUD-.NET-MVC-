namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addVisitDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Visits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateCome = c.DateTime(nullable: false),
                        DateBack = c.DateTime(),
                        Creature_Id = c.Int(nullable: false),
                        Planet_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Creatures", t => t.Creature_Id, cascadeDelete: true)
                .ForeignKey("dbo.Planets", t => t.Planet_Id, cascadeDelete: true)
                .Index(t => t.Creature_Id)
                .Index(t => t.Planet_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visits", "Planet_Id", "dbo.Planets");
            DropForeignKey("dbo.Visits", "Creature_Id", "dbo.Creatures");
            DropIndex("dbo.Visits", new[] { "Planet_Id" });
            DropIndex("dbo.Visits", new[] { "Creature_Id" });
            DropTable("dbo.Visits");
        }
    }
}
