namespace FacebookClone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProfilePicToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ProfilePictureId", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "ProfilePictureId");
            AddForeignKey("dbo.AspNetUsers", "ProfilePictureId", "dbo.Posts", "PostId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "ProfilePictureId", "dbo.Posts");
            DropIndex("dbo.AspNetUsers", new[] { "ProfilePictureId" });
            DropColumn("dbo.AspNetUsers", "ProfilePictureId");
        }
    }
}
