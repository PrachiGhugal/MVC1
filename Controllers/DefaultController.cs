using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class DefaultController : Controller
    {
        public string ID(int id)
        {
            string emp=string.Empty;
            if(id==1)
            {
                emp = "Employee 1";
            }
            else if(id==2)
            {
                emp = "Employee 2";
            }
            else
            {
                emp = "No record found";
            }
            return emp;
        }
        public string Name(string name)
        {
            return "Your name is :"+name;
        }
        public string FullName(string FirstName, string LastName)
        {
            return "FirstName = "+FirstName +" LastName = "+LastName;
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult About()
        {
            return View("AboutUs");
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}