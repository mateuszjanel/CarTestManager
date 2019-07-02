namespace DatabaseLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Make = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        Year = c.Int(nullable: false),
                        Engine = c.String(),
                        FuelConsumingPer100km = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarId = c.Int(nullable: false),
                        TimeToHundred = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: true)
                .Index(t => t.CarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tests", "CarId", "dbo.Cars");
            DropIndex("dbo.Tests", new[] { "CarId" });
            DropTable("dbo.Tests");
            DropTable("dbo.Cars");
        }
    }
}
