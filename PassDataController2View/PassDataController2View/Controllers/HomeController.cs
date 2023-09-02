using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassDataController2View.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            ViewBag.firstname = "Buhnyuy";
            ViewBag.lastname = "Ronald";
            ViewBag.age = 22;
            return View();
        }
	}
}