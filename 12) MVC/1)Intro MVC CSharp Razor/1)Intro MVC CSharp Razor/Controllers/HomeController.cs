using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1_Intro_MVC_CSharp_Razor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Mensaje #1 de tipo: ViewBag";

            ViewData["Mensaje"] = "Mensaje #2 de tipo: ViewData";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult MiVistota()
        {
            return View();
        }
    }
}
