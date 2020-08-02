using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoProj.Models
{
    public class Student
    {
        public string Name
        {
            get; set;
        }

        [Key]
        public int Roll
        {
            get; set;
        }

        [Required]
        public Department Department
        {
            get; set;
        }
    }
}