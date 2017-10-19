using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Nounal.Models;

namespace Nounal.Controllers
{
    public class HomeController : Controller
    {
		public ActionResult Index()
		{
            ViewBag.title = "testing index";
			return View();
		}
        public ActionResult Login(){
            ViewBag.title = "testing login";
            return View();
        }
        public ActionResult About()
        {
            ViewBag.title = "testing about";
            return View();
        }
    }
}
