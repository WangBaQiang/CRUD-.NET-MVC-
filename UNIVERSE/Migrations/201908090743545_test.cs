namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Planets", "PlanetsType_Id", "dbo.PlanetsTypes");
            DropIndex("dbo.Planets", new[] { "PlanetsType_Id" });
            RenameColumn(table: "dbo.Planets", name: "PlanetsType_Id", newName: "PlanetsTypeId");
            AlterColumn("dbo.Planets", "PlanetsTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Planets", "PlanetsTypeId");
            AddForeignKey("dbo.Planets", "PlanetsTypeId", "dbo.PlanetsTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.Planets", "TypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Planets", "TypeId", c => c.Byte(nullable: false));
            DropForeignKey("dbo.Planets", "PlanetsTypeId", "dbo.PlanetsTypes");
            DropIndex("dbo.Planets", new[] { "PlanetsTypeId" });
            AlterColumn("dbo.Planets", "PlanetsTypeId", c => c.Byte());
            RenameColumn(table: "dbo.Planets", name: "PlanetsTypeId", newName: "PlanetsType_Id");
            CreateIndex("dbo.Planets", "PlanetsType_Id");
            AddForeignKey("dbo.Planets", "PlanetsType_Id", "dbo.PlanetsTypes", "Id");
        }
    }
}
