namespace AlphaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProjectIdToPersonReport : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PersonReports", "ProjectId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PersonReports", "ProjectId");
        }
    }
}
