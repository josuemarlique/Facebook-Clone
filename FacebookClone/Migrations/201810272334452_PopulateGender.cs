namespace FacebookClone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGender : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO Genders ( Name ) values ( 'Male' )");
            Sql(@"INSERT INTO Genders ( Name ) values ( 'Female' )");
        }

        public override void Down()
        {
            Sql(@"DELETE FROM Genders WHERE Name = 'Male'");
            Sql(@"DELETE FROM Genders WHERE Name = 'Female'");
        }
    }
}
