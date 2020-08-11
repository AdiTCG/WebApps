using DemoProj.Models;
using System.Data.Entity;

namespace DataAccessor
{
    public class CollegeDbContext : DbContext, ICollegeDbContext
    {
        public DbSet<Student> Students
        {
            get; set;
        }

        public DbSet<Department> Departments
        {
            get; set;
        }
    }
}