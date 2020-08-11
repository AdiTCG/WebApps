using DemoProj.Models;
using System.Data.Entity;

namespace DataAccessor
{
    public interface ICollegeDbContext
    {
        DbSet<Department> Departments
        {
            get;
            set;
        }
        DbSet<Student> Students
        {
            get;
            set;
        }
    }
}