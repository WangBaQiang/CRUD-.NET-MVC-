namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePlanetType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Planets (Name,Galaxy,Features) Values ('BPM 37039','Carbon planet','BPM 37093 is thought to be composed primarily of carbon and oxygen, which are created by thermonuclear fusion of helium nuclei in the triple-alpha process.')");
        }
        
        public override void Down()
        {
        }
    }
}
