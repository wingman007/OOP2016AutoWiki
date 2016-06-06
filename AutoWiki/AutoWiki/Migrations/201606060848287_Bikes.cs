namespace AutoWiki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Bikes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bike",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Model = c.String(),
                        Year = c.Int(nullable: false),
                        Category = c.String(),
                        Engine = c.Int(nullable: false),
                        Power = c.Int(nullable: false),
                        Gearbox = c.String(),
                        Fuel = c.String(),
                        Fuelcapacity = c.Int(nullable: false),
                        Topspeed = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Bike");
        }
    }
}
