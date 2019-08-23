using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab_71_MVC_Framework_Northwind.Controllers
{
    public class test2Controller : Controller
    {
        // GET: tes2
        public ActionResult Index()
        {
            return View("Cricket");
        }


        public ActionResult Golf()
        {
            return View();
        }

        public ActionResult Cricket()
        {
            return View();
        }
    }
}