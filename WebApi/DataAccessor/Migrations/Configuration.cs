namespace DataAccessor.Migrations
{
    using DataModel.Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessor.CollegeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccessor.CollegeDbContext context)
        {
            Department cse = new Department()
            {
                Students = new List<Student>()
                {
                    new Student() { Name = "Subha", Roll = 3, DepartmentId=2 },
                    new Student() { Name = "Prateep", Roll = 8, DepartmentId=2 },
                    new Student() { Name = "Sourav", Roll = 12, DepartmentId=2 }
                },
                Id = 2
            };
            Department it = new Department()
            {
                Students = new List<Student>()
                {
                    new Student() { Name = "Ranadip", Roll = 10, DepartmentId=3 },
                    new Student() { Name = "Suraj", Roll = 10, DepartmentId=3 },
                },
                Id = 3
            };
            context.Departments.Add(cse);
            context.Departments.Add(it);
            base.Seed(context);
        }
    }
}
