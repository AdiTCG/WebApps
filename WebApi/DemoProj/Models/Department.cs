using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoProj.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Hod { get; set; }
        public List<Student> Students { get; set; }
        public Department()
        {
        }
    }
}