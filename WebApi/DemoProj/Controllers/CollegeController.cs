using DemoProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace DemoProj.Controllers
{
    /// <summary>
    /// Class is responsible to handle activities on college
    /// </summary>
    public class CollegeController : ApiController
    {
        List<Department> departments = new List<Department>();
        public CollegeController()
        {
            departments.Add(new Department() { Id = 1, Hod = "KS" });
            departments.Add(new Department() { Id = 2, Hod = "RS" });
        }

        /// <summary>
        /// Get all the departments of the college
        /// </summary>
        /// <returns>Collection of dept</returns>
        [Route("Api/College/GetDepartments")]
        public IEnumerable<Department> Get()
        {
            return departments;
        }
    }
}