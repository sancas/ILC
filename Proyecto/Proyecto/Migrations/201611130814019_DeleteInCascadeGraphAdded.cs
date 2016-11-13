namespace Proyecto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteInCascadeGraphAdded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Edge", "GraphId", "dbo.Graph");
            DropForeignKey("dbo.Node", "GraphId", "dbo.Graph");
            AddForeignKey("dbo.Edge", "GraphId", "dbo.Graph", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Node", "GraphId", "dbo.Graph", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Node", "GraphId", "dbo.Graph");
            DropForeignKey("dbo.Edge", "GraphId", "dbo.Graph");
            AddForeignKey("dbo.Node", "GraphId", "dbo.Graph", "Id");
            AddForeignKey("dbo.Edge", "GraphId", "dbo.Graph", "Id");
        }
    }
}
