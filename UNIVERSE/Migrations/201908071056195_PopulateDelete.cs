namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDelete : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Planets WHERE Galaxy ='Milk Way'");
        }
        
        public override void Down()
        {
        }
    }
}
