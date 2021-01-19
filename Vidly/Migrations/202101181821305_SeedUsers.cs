namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'57057f3a-d571-4831-bb62-0fe63e270fe6', N'guest@gmail.com', 0, N'ANNUnCUqxiZW/93R9GMqeEGFwIRYWPqenrcKriLxYEU60zIcQ8iuDYYgTiEiHVNL5w==', N'1f3d64c6-d807-444d-b902-b8ba250afe35', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'96843bb1-5411-4dc6-adbc-71244f422d68', N'admin@vidly.com', 0, N'AG7X+riqUgvNPojDS9xK2IU2DanqBQ9af92+oxmiyVaxPnDRq3anhjJk6YtTZkun0g==', N'bd33da48-61a1-445b-aa6a-be70b6a4dfdf', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                    
                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'be9e7d2d-486d-42fe-a987-910f6c446cd6', N'CanManageMovies')
                  
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'96843bb1-5411-4dc6-adbc-71244f422d68', N'be9e7d2d-486d-42fe-a987-910f6c446cd6')
                ");
        }

        public override void Down()
        {
        }
    }
}
