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
        public CollegeController()
        {

        }

        /// <summary>
        /// Get all the departments of the college
        /// </summary>
        /// <returns>Collection of dept</returns>
        [Route("Api/College/GetDepartments")]
        public IEnumerable<Department> Get()
        {

        }
    }
}