namespace DataAccessor.Migrations
{
    using DemoProj.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessor.CollegeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccessor.CollegeDbContext context)
        {
            Department department = new Department()
            {
                Students = new List<Student>()
                {
                    new Student() { Name = "Ranadip", Roll = 10 },
                    new Student() { Name = "Subha", Roll = 3 },
                    new Student() { Name = "Prateep", Roll = 8 },
                    new Student() { Name = "Sourav", Roll = 12 }
                }
            };

            context.Departments.Add(department);
            base.Seed(context);
        }
    }
}
