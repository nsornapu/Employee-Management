namespace test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateData : DbMigration
    {
        public override void Up()
        {
            //Sql("INSERT INTO Employees (id, name, phoneNumber, email,skillId, departmentId) VALUES (1, 'Naresh', '4694109998', 'naresh.sornapudi@gmail.com', 1, 1)");
            //Sql("INSERT INTO Employees (id, name, phoneNumber, email,skillId, departmentId) VALUES (2, 'Surya', '4104699998', 'surya.mc@gmail.com', 2,2)");
            //Sql("INSERT INTO Employees (id, name, phoneNumber, email, skillId,departmentId) VALUES (3, 'Wags', '9464109998', 'naresh.sornapudi@utd.com', 3,3)");
            //Sql("INSERT INTO Employees (id, name, phoneNumber, email,skillId, departmentId) VALUES (4, 'Naresh', '4594109998', 'naresh.sornapudi@yahoo.com', 1,1)");
            //Sql("INSERT INTO Employees (id, name, phoneNumber, email,skillId, departmentId) VALUES (5, 'Naresh', '4698109998', 'naresh.sornapudi@joker.com', 2,2)");

            //Sql("INSERT INTO Departments (id, name) VALUES (1, 'IT')");
            //Sql("INSERT INTO Departments (id, name) VALUES (2, 'Education')");
            //Sql("INSERT INTO Departments (id, name) VALUES (3, 'Services')");

            //Sql("INSERT INTO Skills (id, name) VALUES (1, 'Java')");
            //Sql("INSERT INTO Skills (id, name) VALUES (2, 'C#')");
            //Sql("INSERT INTO Skills (id, name) VALUES (3, 'Python')");

        }
        
        public override void Down()
        {
        }
    }
}
