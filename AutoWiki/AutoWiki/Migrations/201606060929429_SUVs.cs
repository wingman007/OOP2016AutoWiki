namespace AutoWiki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SUVs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SUVs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Model = c.String(),
                        Engine = c.String(),
                        HorsePower = c.String(),
                        MaxSpeed = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SUVs");
        }
    }
}
