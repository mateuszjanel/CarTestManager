namespace DatabaseLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class names_fix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "CarModel", c => c.String(nullable: false));
            DropColumn("dbo.Cars", "Model");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "Model", c => c.String(nullable: false));
            DropColumn("dbo.Cars", "CarModel");
        }
    }
}
