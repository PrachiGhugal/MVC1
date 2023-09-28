using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult EmployeeList()
        {
            Employee employee = new Employee()
            {
                EmpId = 1,
                Empname="Prachi",
                EmpAddress="Abc def ghi jkl mno pqr stu vwx yz",
                Empsalary=50000
            };

            return View(employee);
        }
    }
}