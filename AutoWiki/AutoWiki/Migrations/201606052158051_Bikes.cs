namespace AutoWiki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Bikes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bikes", "Fuelcapacity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bikes", "Fuelcapacity", c => c.Double(nullable: false));
        }
    }
}
