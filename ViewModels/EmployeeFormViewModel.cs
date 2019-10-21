using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using test.Models;

namespace test.ViewModels
{
    public class EmployeeFormViewModel
    {
        public Employee employee { get; set; }
        public List<Skill> skills { get; set; }
        public List<Department> departments { get; set; }
    }
}