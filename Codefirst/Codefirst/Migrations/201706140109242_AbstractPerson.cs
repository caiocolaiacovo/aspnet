namespace Codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AbstractPerson : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.People", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
    }
}
