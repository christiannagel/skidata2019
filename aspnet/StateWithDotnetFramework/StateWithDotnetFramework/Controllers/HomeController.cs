using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateWithDotnetFramework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult SetSessionState(string id)
        {
            Session["mystate"] = id;
            return View();
        }

        public ActionResult GetSessionState()
        {
            string value = Session["mystate"]?.ToString() ?? string.Empty;
            ViewBag.MyState = value;
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