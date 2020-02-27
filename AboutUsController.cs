using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//add namespace
using MVC5EF6Tables.Models;

namespace MVC5EF6Tables.Controllers
{
    public class AboutUsController : Controller
    {
        // GET: AboutUs
        public ActionResult Index()
        {
            //make a connection to the backend database using the context class.
            EmployeeContext employeeContext = new EmployeeContext();

            //create a list of ChurchHistory object, then store into churchHistory.
            List<AboutUs> aboutUs = employeeContext.AboutUs.ToList();

            //pass the variable churchHistory to the view to render.
            return View(aboutUs);

        }
    }
}