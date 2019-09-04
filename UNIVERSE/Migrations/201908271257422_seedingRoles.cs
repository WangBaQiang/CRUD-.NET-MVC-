namespace UNIVERSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingRoles : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2178bf86-91eb-4a18-a34d-050b0315d282', N'Admin@Universe.com', 0, N'AEynPg4ofyoRGGxkbR93HHOKeeBgCRU3ERN5f6CqjN2G8kz+BQBJQgLc+C7TorF1bw==', N'5fc4eed1-bc96-4339-999b-a32f4c334e25', NULL, 0, 0, NULL, 1, 0, N'Admin@Universe.com')
                        INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'51426b93-4977-4dbe-8417-80a3d069d38b', N'Guest@Universe.com', 0, N'ANR9aHok9dwVD0DqYX/bMnkhM+PLIhRtzSQO7oIRzqP65sycQDkYsBnHLgJ1qyqNzQ==', N'406b91ba-1a6e-4138-9fb1-ad2c794d825a', NULL, 0, 0, NULL, 1, 0, N'Guest@Universe.com')
                        INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd6d4cf81-a230-4191-b37d-b1ecb327f9e9', N'CanManagePlanets')
                        INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2178bf86-91eb-4a18-a34d-050b0315d282', N'd6d4cf81-a230-4191-b37d-b1ecb327f9e9')
                        ");
        }
        
        public override void Down()
        {
        }
    }
}
