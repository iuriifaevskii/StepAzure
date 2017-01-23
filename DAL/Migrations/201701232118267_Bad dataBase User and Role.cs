namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BaddataBaseUserandRole : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "RoleId");
            DropColumn("dbo.Roles", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Roles", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "RoleId", c => c.Int(nullable: false));
        }
    }
}
