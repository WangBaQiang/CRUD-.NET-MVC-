namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlanetsTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Planets", "TypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Planets", "PlanetsType_Id", c => c.Byte());
            CreateIndex("dbo.Planets", "PlanetsType_Id");
            AddForeignKey("dbo.Planets", "PlanetsType_Id", "dbo.PlanetsTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Planets", "PlanetsType_Id", "dbo.PlanetsTypes");
            DropIndex("dbo.Planets", new[] { "PlanetsType_Id" });
            DropColumn("dbo.Planets", "PlanetsType_Id");
            DropColumn("dbo.Planets", "TypeId");
            DropTable("dbo.PlanetsTypes");
        }
    }
}
