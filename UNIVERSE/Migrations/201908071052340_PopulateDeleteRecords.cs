namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDeleteRecords : DbMigration
    {
        public override void Up()
        {
    
            Sql("DELETE FROM Planets WHERE Id =3");
        }
        
        public override void Down()
        {
        }
    }
}
