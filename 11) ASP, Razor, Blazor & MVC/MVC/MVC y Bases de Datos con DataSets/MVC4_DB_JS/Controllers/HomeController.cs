using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Data;
using MVC4_DB_JS.Models;//Hacemos una referencia al Modelo

namespace MVC4_DB_JS.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult VistaAjaxJQuery()
        {
            return View();
        }

        public ActionResult VistaAjaxJS()
        {
            return View();
        }

        public ActionResult Index()
        {
            var MiDataSet = new DataSet();
            var ObjetoPersonas = new PersonasDB_Class();

            List<ModeloPersonas> Lista = new List<ModeloPersonas>();  // Creamos una lista de Modelos    

            MiDataSet = ObjetoPersonas.ConsultaPersonas(); //Cargamos en el DataSet la tabla de personas

            foreach (DataRow dr in MiDataSet.Tables[0].Rows)
            {
                Lista.Add(new ModeloPersonas
                {
                    Cedula = dr["Cedula"].ToString(),
                    Nombre = dr["Nombre"].ToString(),
                    Telefono = dr["Telefono"].ToString(),
                    Direccion = dr["Direccion"].ToString(),
                    Correo = dr["Correo"].ToString()
                });
            }//foreach

            return View(Lista);
        }//Index

        public ActionResult IndexJson()
        {
            var MiDataSet = new DataSet();
            var ObjetoPersonas = new PersonasDB_Class();

            List<ModeloPersonas> Lista = new List<ModeloPersonas>();  // Creamos una lista de Modelos    

            MiDataSet = ObjetoPersonas.ConsultaPersonas(); //Cargamos en el DataSet la tabla de personas

            foreach (DataRow dr in MiDataSet.Tables[0].Rows)
            {
                Lista.Add(new ModeloPersonas
                {
                    Cedula = dr["Cedula"].ToString(),
                    Nombre = dr["Nombre"].ToString(),
                    Telefono = dr["Telefono"].ToString(),
                    Direccion = dr["Direccion"].ToString(),
                    Correo = dr["Correo"].ToString()
                });
            }//foreach

            return Json(Lista, JsonRequestBehavior.AllowGet);
        }//Index

        public ActionResult InsertaPersonas() // Este es para la primera vez que entra a la página.
        {
            return View();
        }//InsertaPersonas #1

        [HttpPost]
        public ActionResult InsertaPersonas(ModeloPersonas MP) // Para el Submit en el Post
        {
            var ObjetoPersonas = new PersonasDB_Class();
            Int32 FilasAfectadas = 0;

            if (ModelState.IsValid) //Revisa si el modelo is valido o no
            {
                FilasAfectadas = ObjetoPersonas.InsertaPersonas(MP.Cedula, MP.Nombre, MP.Telefono, MP.Direccion, MP.Correo);

                ViewData["resultado"] = FilasAfectadas;
                ModelState.Clear();
                return View();
            }
            else
            {
                ModelState.AddModelError("", "Error al guardar la persona");
                return View();
            }
        }//InsertaPersonas #2

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
