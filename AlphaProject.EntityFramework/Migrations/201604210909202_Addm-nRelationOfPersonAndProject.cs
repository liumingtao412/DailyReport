namespace AlphaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddmnRelationOfPersonAndProject : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Person_Project",
                c => new
                    {
                        PersonId = c.Int(nullable: false),
                        ProjectId = c.Int(nullable: false),
                        isProjectLeader = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.PersonId, t.ProjectId })
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.PersonId)
                .Index(t => t.ProjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Person_Project", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.Person_Project", "PersonId", "dbo.People");
            DropIndex("dbo.Person_Project", new[] { "ProjectId" });
            DropIndex("dbo.Person_Project", new[] { "PersonId" });
            DropTable("dbo.Person_Project");
        }
    }
}
