namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsr : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [DrivingLicense], [Phone], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'36de3053-9376-40c4-86e3-5145351eed98', N'driving', N'1132323', N'admin@vidly.com', 0, N'APdloINjTi1017ydh3QqwIoqYqGIvXbnSL6QlE92rCQYeGIriaADffoLf618rQ5bVg==', N'826c42de-c555-4a87-acf6-38402b98dea5', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [DrivingLicense], [Phone], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bf06e114-ea00-44a4-9b5f-cc67c3a2b4fd', N'driving', N'1132323', N'guest@vidly.com', 0, N'ABk3GZLOxCK1yhIxCYnXWca1ND3hlnBVXgNCN3AgknSiShESH3O30dXhsFnJVSwwJA==', N'02681b52-d582-417d-ad5d-339cd1a98de4', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4501014a-7510-4aa0-a44c-62de4c71ad66', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'36de3053-9376-40c4-86e3-5145351eed98', N'4501014a-7510-4aa0-a44c-62de4c71ad66')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
