using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First_App.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.m = "namee";
            List<string> nameList = new List<string>();
            nameList.Add("name1");
            nameList.Add("name2");
            nameList.Add("name3");
            nameList.Add("name4");
            nameList.Add("name5");
            ViewBag.nameLists = nameList;
            return View();
        }
    }
}