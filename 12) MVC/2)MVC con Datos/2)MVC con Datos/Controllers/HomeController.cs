using _2_MVC_con_Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_MVC_con_Datos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List < Persona > ListaPersonas = new List<Persona>
            {
                new Persona { ID = 1, Nombre = "Leonardo", Telefono = "1111-1111" },
                new Persona { ID = 2, Nombre = "Donatello", Telefono = "2222-2222" },
                new Persona { ID = 3, Nombre = "Miguel Angel", Telefono = "3333-3333" },
                new Persona { ID = 4, Nombre = "Rafael", Telefono = "4444-4444" },
            };

            return View(ListaPersonas);
        }

        public ActionResult InsertaPersona()
        {           
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}
