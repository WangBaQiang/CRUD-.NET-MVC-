namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePrivilege : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Privileges(Id, stonesNeeded,DurationOfPrivilege,PrivilegeRate) Values (1,0,0,0)");
            Sql("INSERT INTO Privileges(Id, stonesNeeded,DurationOfPrivilege,PrivilegeRate) Values (2,100,3,20)");
            Sql("INSERT INTO Privileges(Id, stonesNeeded,DurationOfPrivilege,PrivilegeRate) Values (3,200,6,50)");
            Sql("INSERT INTO Privileges(Id, stonesNeeded,DurationOfPrivilege,PrivilegeRate) Values (4,300,12,80)");
        }
        
        public override void Down()
        {
        }
    }
}
