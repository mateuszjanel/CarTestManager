namespace DatabaseLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test_nullable_variables : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tests", "TimeToHundred", c => c.Single());
            AlterColumn("dbo.Tests", "Acceleration", c => c.Single());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tests", "Acceleration", c => c.Single(nullable: false));
            AlterColumn("dbo.Tests", "TimeToHundred", c => c.Single(nullable: false));
        }
    }
}
