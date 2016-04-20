namespace AlphaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRemarks : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Remarks", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "Remarks");
        }
    }
}
