using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeManagement.Models;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        // GET: Employee/Name
        [Route("Employee/Random")]
        public ActionResult Random()
        {
            var Employee = new Employee() { name = "Naresh"};
            return View(Employee);
        }
    }
}