﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoGitHub.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
            //abv
        }
//test 1611
        //
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";



            //test by chintan



//
            return View();
        }
        //uuuyyu
        public ActionResult Contact()
        {

            ViewBag.Message = "Your contact page.";

            return View();

        }//
    }
}