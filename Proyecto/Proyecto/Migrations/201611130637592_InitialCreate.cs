namespace Proyecto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Edge",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NodoSalida = c.String(nullable: false),
                        NodoLlegada = c.String(nullable: false),
                        Value = c.Int(nullable: false),
                        GraphId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Graph", t => t.GraphId)
                .Index(t => t.GraphId);
            
            CreateTable(
                "dbo.Graph",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipo = c.String(nullable: false),
                        Background = c.Binary(),
                        NodeIcon = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Node",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        X = c.Int(nullable: false),
                        Y = c.Int(nullable: false),
                        GraphId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Graph", t => t.GraphId)
                .Index(t => t.GraphId);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Gender = c.String(nullable: false, maxLength: 1, unicode: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Role", t => t.RoleId)
                .Index(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "RoleId", "dbo.Role");
            DropForeignKey("dbo.Node", "GraphId", "dbo.Graph");
            DropForeignKey("dbo.Edge", "GraphId", "dbo.Graph");
            DropIndex("dbo.User", new[] { "RoleId" });
            DropIndex("dbo.Node", new[] { "GraphId" });
            DropIndex("dbo.Edge", new[] { "GraphId" });
            DropTable("dbo.User");
            DropTable("dbo.Role");
            DropTable("dbo.Node");
            DropTable("dbo.Graph");
            DropTable("dbo.Edge");
        }
    }
}
