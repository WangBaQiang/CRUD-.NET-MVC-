namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePlanets : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Planets (Name,Galaxy,Features,TypeId) Values ('BPM 37039','Centaurus','BPM 37093 is thought to be composed primarily of carbon and oxygen, which are created by thermonuclear fusion of helium nuclei in the triple-alpha process.',1)");
        }
        
        public override void Down()
        {
        }
    }
}
