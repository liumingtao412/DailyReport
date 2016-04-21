namespace AlphaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProjectClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(),
                        isStarted = c.Boolean(nullable: false),
                        isFinished = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProjectReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Contents = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        IsSent = c.Boolean(nullable: false),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.ProjectID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProjectReports", "ProjectID", "dbo.Projects");
            DropIndex("dbo.ProjectReports", new[] { "ProjectID" });
            DropTable("dbo.ProjectReports");
            DropTable("dbo.Projects");
        }
    }
}
