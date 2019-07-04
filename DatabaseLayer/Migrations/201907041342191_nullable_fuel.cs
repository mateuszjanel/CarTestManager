namespace DatabaseLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullable_fuel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "FuelConsumingPer100km", c => c.Single());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "FuelConsumingPer100km", c => c.Single(nullable: false));
        }
    }
}
