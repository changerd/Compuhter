namespace Compuhter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Checks",
                c => new
                    {
                        CheckId = c.Int(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CheckDate = c.DateTime(nullable: false),
                        ClientId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CheckId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        SurName = c.String(),
                        FirstName = c.String(),
                        SecondName = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.ClientId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        EmployeeSurName = c.String(),
                        EmployeeFirstName = c.String(),
                        EmployeeSecondName = c.String(),
                        EmployeeTelephone = c.String(),
                        PositionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Positions", t => t.PositionId, cascadeDelete: true)
                .Index(t => t.PositionId);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        PositionId = c.Int(nullable: false, identity: true),
                        PositionName = c.String(),
                    })
                .PrimaryKey(t => t.PositionId);
            
            CreateTable(
                "dbo.ProductChecks",
                c => new
                    {
                        ProductCheckId = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        CheckId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductCheckId)
                .ForeignKey("dbo.Checks", t => t.CheckId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.CheckId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductManufacturer = c.String(),
                        ProductName = c.String(),
                        ProductCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductChecks", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductChecks", "CheckId", "dbo.Checks");
            DropForeignKey("dbo.Employees", "PositionId", "dbo.Positions");
            DropForeignKey("dbo.Checks", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Checks", "ClientId", "dbo.Clients");
            DropIndex("dbo.ProductChecks", new[] { "CheckId" });
            DropIndex("dbo.ProductChecks", new[] { "ProductId" });
            DropIndex("dbo.Employees", new[] { "PositionId" });
            DropIndex("dbo.Checks", new[] { "EmployeeId" });
            DropIndex("dbo.Checks", new[] { "ClientId" });
            DropTable("dbo.Products");
            DropTable("dbo.ProductChecks");
            DropTable("dbo.Positions");
            DropTable("dbo.Employees");
            DropTable("dbo.Clients");
            DropTable("dbo.Checks");
        }
    }
}
