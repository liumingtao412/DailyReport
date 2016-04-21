namespace AlphaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProjectStateeNum2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "State", c => c.Int(nullable: false));
            DropColumn("dbo.Projects", "isStarted");
            DropColumn("dbo.Projects", "isFinished");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Projects", "isFinished", c => c.Boolean(nullable: false));
            AddColumn("dbo.Projects", "isStarted", c => c.Boolean(nullable: false));
            DropColumn("dbo.Projects", "State");
        }
    }
}
