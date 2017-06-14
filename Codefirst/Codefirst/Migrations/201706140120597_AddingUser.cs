namespace Codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Login", c => c.String());
            AddColumn("dbo.People", "Password", c => c.String());
            AddColumn("dbo.People", "Role", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Role");
            DropColumn("dbo.People", "Password");
            DropColumn("dbo.People", "Login");
        }
    }
}
