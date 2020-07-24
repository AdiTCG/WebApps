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
        public List<Student> Students { get; }
        public Department()
        {
            Students = new List<Student>()
            {
                new Student(){Roll=1, Name="AA"},
                new Student(){Roll=2, Name="BB"}
            };
        }
    }
}