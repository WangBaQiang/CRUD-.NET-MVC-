namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePrivilegesforce : DbMigration
    {
        // I did some stupid thing in this part, the content are different from the file name, please ignore.
        public override void Up()
        {
            Sql("INSERT INTO Privileges(Id, stonesNeeded,DurationOfPrivilege,PrivilegeRate) Values (1,0,0,0)");
        }
        
        public override void Down()
        {
            Sql("INSERT INTO Privileges(Id, stonesNeeded,DurationOfPrivilege,PrivilegeRate) Values (5,1000,18,70)");
        }
    }
}
