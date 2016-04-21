namespace AlphaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRemarks1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PersonReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Contents = c.String(nullable: false),
                        ReportDate = c.DateTime(nullable: false),
                        PersonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PersonID, cascadeDelete: true)
                .Index(t => t.PersonID);
            
            AddColumn("dbo.People", "EMail", c => c.String());
            AddColumn("dbo.People", "Mobile", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonReports", "PersonID", "dbo.People");
            DropIndex("dbo.PersonReports", new[] { "PersonID" });
            DropColumn("dbo.People", "Mobile");
            DropColumn("dbo.People", "EMail");
            DropTable("dbo.PersonReports");
        }
    }
}
