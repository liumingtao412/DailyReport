namespace AlphaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserToPerson : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "User_Id", c => c.Long());
            CreateIndex("dbo.People", "User_Id");
            AddForeignKey("dbo.People", "User_Id", "dbo.AbpUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "User_Id", "dbo.AbpUsers");
            DropIndex("dbo.People", new[] { "User_Id" });
            DropColumn("dbo.People", "User_Id");
        }
    }
}
