namespace SmartFrame.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        OwnerId = c.Int(nullable: false),
                        MoodId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Moods", t => t.MoodId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.OwnerId, cascadeDelete: true)
                .Index(t => t.OwnerId)
                .Index(t => t.MoodId);
            
            CreateTable(
                "dbo.Moods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                        PasswordHash = c.String(),
                        Salt = c.String(),
                        CityName = c.String(),
                        PhotoModeId = c.Int(),
                        MoodId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PhotoModes", t => t.PhotoModeId)
                .ForeignKey("dbo.Moods", t => t.MoodId)
                .Index(t => t.PhotoModeId)
                .Index(t => t.MoodId);
            
            CreateTable(
                "dbo.PhotoModes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WeatherSaveds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WindDirectionType = c.String(),
                        WindSpeed = c.Int(nullable: false),
                        Temperature = c.Int(nullable: false),
                        TemperatureFeelsLike = c.Int(nullable: false),
                        WindGust = c.Int(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.WeatherOnlines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WindDirectionType = c.String(),
                        WindSpeed = c.Int(nullable: false),
                        Temperature = c.Int(nullable: false),
                        TemperatureFeelsLike = c.Int(nullable: false),
                        WindGust = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        CityName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "MoodId", "dbo.Moods");
            DropForeignKey("dbo.WeatherSaveds", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "PhotoModeId", "dbo.PhotoModes");
            DropForeignKey("dbo.Images", "OwnerId", "dbo.Users");
            DropForeignKey("dbo.Images", "MoodId", "dbo.Moods");
            DropIndex("dbo.WeatherSaveds", new[] { "User_Id" });
            DropIndex("dbo.Users", new[] { "MoodId" });
            DropIndex("dbo.Users", new[] { "PhotoModeId" });
            DropIndex("dbo.Images", new[] { "MoodId" });
            DropIndex("dbo.Images", new[] { "OwnerId" });
            DropTable("dbo.WeatherOnlines");
            DropTable("dbo.WeatherSaveds");
            DropTable("dbo.PhotoModes");
            DropTable("dbo.Users");
            DropTable("dbo.Moods");
            DropTable("dbo.Images");
        }
    }
}
