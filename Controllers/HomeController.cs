﻿using System;
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
        public ActionResult Aboutus(int id = 0)
        {
            ViewBag.n = "nameess";
            ViewBag.id = id;

            return View();
        }

        public ActionResult APart()
        {
            ViewBag.n = "name2";

            return View();
        }


        [Route("About/{name?}")]
        public ActionResult Abouts(string name)
        {
            ViewBag.name = name;

            return PartialView();
        }

    }
}