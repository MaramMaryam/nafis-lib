using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First_App.Controllers
{
    public class ModlBindController : Controller
    {
        // GET: ModlBind
        public ActionResult Index(string name, string family, int age)
        {
            if (age <= 10)
            {
                ViewBag.Message = "شما به سن قانونی نرسیده اید!";
                return View("_Message");
            }
            ViewBag.Name = name;
            ViewBag.Family = family;
            ViewBag.Age = age;
            return View();
        }
    }
}