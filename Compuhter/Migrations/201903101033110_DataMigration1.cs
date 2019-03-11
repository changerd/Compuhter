namespace Compuhter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clients", "SecondName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "SecondName", c => c.String());
        }
    }
}
