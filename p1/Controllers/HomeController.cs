﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace p1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult hello()
        {
            int a = 11;
            int sum = 0;
            for (int i = 1; i <= a; i++)
            {
                sum += i;
            }
            ViewBag.sum = sum;
            return View();
        }
    }
}