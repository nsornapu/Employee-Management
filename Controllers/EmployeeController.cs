using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;
using test.ViewModels;

namespace test.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private ApplicationDbContext _context;
        public EmployeeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Employee
        
        public ActionResult Index()
        {
            var employees = _context.Employees;
            return View(employees);
        }
        // GET: Employee/Name
        //[Route("Employee/Random")]
        public ActionResult Random()
        {
            var employees = new EmployeesListViewModel();
            employees.employees = _context.Employees.ToList();
            return View(employees);
        }

        public ActionResult Details()
        {
            var employees = new EmployeesListViewModel();
            employees.employees = _context.Employees.ToList();
            if (User.IsInRole("CanManageEmployees"))
            {
                return View(employees);
            }
            else
            {
                return View("ReadOnlyList", employees);
            }
            
        }

        public ActionResult NewEmployee()
        {
            var data = new EmployeeFormViewModel();
            data.skills = _context.Skills.ToList();
            data.departments = _context.Departments.ToList();
            //var employees = new EmployeesListViewModel();
            //employees.employees = _context.Employees.ToList();
            return View(data);
        }

        [HttpPost]
        public ActionResult Save(Employee employee)
        {
            if (User.IsInRole("CanManageEmployees"))
            {
                if (employee.id == 0)
                {
                    _context.Employees.Add(employee);
                }
                else
                {
                    var employeeInDB = _context.Employees.Single(e => e.id == employee.id);
                    employeeInDB.name = employee.name;
                    employeeInDB.email = employee.email;
                    employeeInDB.phoneNumber = employee.phoneNumber;
                    employeeInDB.departmentId = employee.departmentId;
                    employeeInDB.skillId = employee.skillId;
                }

                _context.SaveChanges();
                return RedirectToAction("Details", "Employee");
            }
            else
            {
                return HttpNotFound();
            }
        }

        public ActionResult Delete(int id)
        {
            if (User.IsInRole("CanManageEmployees"))
            {
                //_context.Employees.Add(employee);
                //_context.SaveChanges();
                var employee = _context.Employees.SingleOrDefault(e => e.id == id);

                if (employee == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    _context.Employees.Remove(employee);
                }
                var employees = new EmployeesListViewModel();
                employees.employees = _context.Employees.ToList();
                return View("Details", employees);
            }
            else
            {
                return HttpNotFound();
            }
        }

        public ActionResult Edit(int id)
        {
            if (User.IsInRole("CanManageEmployees"))
            {
                //_context.Employees.Add(employee);
                //_context.SaveChanges();
                var employee = _context.Employees.SingleOrDefault(e => e.id == id);

                if (employee == null)
                {
                    return HttpNotFound();
                }
                var viewModel = new EmployeeFormViewModel
                {
                    employee = employee,
                    departments = _context.Departments.ToList(),
                    skills = _context.Skills.ToList()
                };
                return View("NewEmployee", viewModel);
            }
            else
            {
                return HttpNotFound();
            }
        }

        public ActionResult DetailsById(int id)
        {
            //_context.Employees.Add(employee);
            //_context.SaveChanges();
            return RedirectToAction("Details", "Employee");
        }
    }
}