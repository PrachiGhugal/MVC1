using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC1.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Empname { get; set; }
        public string EmpAddress { get; set; }
        public int Empsalary { get; set; }
    }
}