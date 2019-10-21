namespace test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateData2 : DbMigration
    {
        public override void Up()
        {
            //Sql("SET IDENTITY_INSERT Employees ON");
            //Sql("SET IDENTITY_INSERT Departments ON");
            //Sql("SET IDENTITY_INSERT Skills ON");

            Sql("INSERT INTO Employees ( name, phoneNumber, email,skillId, departmentId) VALUES ( 'Naresh', '4694109998', 'naresh.sornapudi@gmail.com', 1, 1)");
            Sql("INSERT INTO Employees ( name, phoneNumber, email,skillId, departmentId) VALUES ('Surya', '4104699998', 'surya.mc@gmail.com', 2,2)");
            Sql("INSERT INTO Employees ( name, phoneNumber, email, skillId,departmentId) VALUES ('Wags', '9464109998', 'naresh.sornapudi@utd.com', 3,3)");
            Sql("INSERT INTO Employees ( name, phoneNumber, email,skillId, departmentId) VALUES ('Naresh', '4594109998', 'naresh.sornapudi@yahoo.com', 1,1)");
            Sql("INSERT INTO Employees ( name, phoneNumber, email,skillId, departmentId) VALUES ('Naresh', '4698109998', 'naresh.sornapudi@joker.com', 2,2)");

            Sql("INSERT INTO Departments ( name) VALUES ( 'IT')");
            Sql("INSERT INTO Departments ( name) VALUES ('Education')");
            Sql("INSERT INTO Departments ( name) VALUES ('Services')");

            Sql("INSERT INTO Skills ( name) VALUES ( 'Java')");
            Sql("INSERT INTO Skills ( name) VALUES ('C#')");
            Sql("INSERT INTO Skills ( name) VALUES ('Python')");
        }
        
        public override void Down()
        {
        }
    }
}
