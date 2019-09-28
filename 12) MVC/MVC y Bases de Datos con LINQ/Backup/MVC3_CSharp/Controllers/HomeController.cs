using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC3_CSharp.Models; // #1) Agregamos esto antes

namespace MVC3_CSharp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // #2) Creamos una instancia del DataContext que esta en el Model
            PersonasDataClassesDataContext PersonasData = new PersonasDataClassesDataContext();

            // #3) Hacemos un query de Linq para seleccionar los datos del DataContext
            var Gente = from p in PersonasData.Personas select p;
            
            // #4) Regresamos el Query
            return View(Gente);
        }

        public ActionResult PersonasJson()
        {
            PersonasDataClassesDataContext PersonasData = new PersonasDataClassesDataContext();
            var Gente = from p in PersonasData.Personas select p;
            return Json(Gente);
            //return Json(new List<TaxRecord>());
            //return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
