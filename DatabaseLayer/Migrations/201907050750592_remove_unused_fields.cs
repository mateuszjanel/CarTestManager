namespace DatabaseLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_unused_fields : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cars", "FuelConsumingPer100km");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "FuelConsumingPer100km", c => c.Single());
        }
    }
}
