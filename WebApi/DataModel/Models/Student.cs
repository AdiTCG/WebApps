using System.ComponentModel.DataAnnotations;

namespace DataModel.Models
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
        public int DepartmentId
        {
            get; set;
        }
    }
}
