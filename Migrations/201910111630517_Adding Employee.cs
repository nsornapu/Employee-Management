namespace test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingEmployee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        phoneNumber = c.String(),
                        email = c.String(),
                        departmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
