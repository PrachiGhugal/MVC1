using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class ClassWorkController : Controller
    {
        public ActionResult Assignments()
        {
            return View();
        }

        public ActionResult Exam()
        {
            return View("AnnualExam");
        }
        
    }
}