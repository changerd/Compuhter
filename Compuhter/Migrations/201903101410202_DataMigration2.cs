namespace Compuhter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "ClientSurName", c => c.String());
            AddColumn("dbo.Clients", "ClientFirstName", c => c.String());
            AddColumn("dbo.Clients", "ClientTelephone", c => c.String());
            DropColumn("dbo.Clients", "SurName");
            DropColumn("dbo.Clients", "FirstName");
            DropColumn("dbo.Clients", "Telephone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "Telephone", c => c.String());
            AddColumn("dbo.Clients", "FirstName", c => c.String());
            AddColumn("dbo.Clients", "SurName", c => c.String());
            DropColumn("dbo.Clients", "ClientTelephone");
            DropColumn("dbo.Clients", "ClientFirstName");
            DropColumn("dbo.Clients", "ClientSurName");
        }
    }
}
