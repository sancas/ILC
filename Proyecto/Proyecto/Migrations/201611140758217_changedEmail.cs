namespace Proyecto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "Username", c => c.String(nullable: false));
            DropColumn("dbo.User", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.User", "Email", c => c.String(nullable: false));
            DropColumn("dbo.User", "Username");
        }
    }
}
