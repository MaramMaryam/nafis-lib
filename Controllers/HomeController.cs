using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First_App.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }     
        public ActionResult myView()
        {
            return View();
        }
        public ActionResult Aboutus()
        {
            return View();
        }
     
    }
}