namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePrivilegeName : DbMigration
    {
        public override void Up()
        {
            Sql("Update Privileges SET PrivilegeName = 'Rate One' WHERE Id =1");
            Sql("Update Privileges SET PrivilegeName = 'Rate Two' WHERE Id =2");
            Sql("Update Privileges SET PrivilegeName = 'Rate Three' WHERE Id =3");
            Sql("Update Privileges SET PrivilegeName = 'Rate Four' WHERE Id =4");
            Sql("Update Privileges SET PrivilegeName = 'Rate Five' WHERE Id =5");

        }
        
        public override void Down()
        {
        }
    }
}
