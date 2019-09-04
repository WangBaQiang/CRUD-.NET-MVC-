namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO PlanetsTypes(Id, Name) Values (1,'Carbon Planet')");
            Sql("INSERT INTO PlanetsTypes(Id, Name) Values (2,'Dwarf Planet')");
            Sql("INSERT INTO PlanetsTypes(Id, Name) Values (3,'Ice Giant')");
        }
        
        public override void Down()
        {
        }
    }
}
