namespace test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateData1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "skillId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "skillId");
        }
    }
}
