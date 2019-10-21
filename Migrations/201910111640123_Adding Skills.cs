namespace test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingSkills : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Skills");
        }
    }
}
