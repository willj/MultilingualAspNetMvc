using GlobalisationTest.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GlobalisationTest.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.UrlCulture = RouteData.Values["culture"];
            ViewBag.Culture = Thread.CurrentThread.CurrentCulture.ToString();
            ViewBag.UiCulture = Thread.CurrentThread.CurrentUICulture.ToString();
            ViewBag.Hello = Resources.Resources.Greeting;
            return View();
        }

        [HttpGet]
        public ActionResult Send(){
            return View();
        }

        [HttpPost]
        public ActionResult Send([Bind(Include="Name,Email")]Entry entry)
        {
            if (ModelState.IsValid)
	        {
                		 
	        }

            return View();
        }

    }
}