namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoreTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO PlanetsTypes(Id, Name) Values (4,'Unknown')");
        }
        
        public override void Down()
        {
        }
    }
}
