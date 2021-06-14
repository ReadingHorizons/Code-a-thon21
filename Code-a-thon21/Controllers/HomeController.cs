﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassroomDataBase;

namespace Code_a_thon21.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ClassroomDB DB = new ClassroomDB();
            var teacherList = DB.Teachers.ToList();
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
    }
}