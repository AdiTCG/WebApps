using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Models
{
    public class Department
    {
        public int Id
        {
            get; set;
        }
        public string Hod
        {
            get; set;
        }
        public List<Student> Students
        {
            get; set;
        }
        public Department()
        {
        }
    }
}
