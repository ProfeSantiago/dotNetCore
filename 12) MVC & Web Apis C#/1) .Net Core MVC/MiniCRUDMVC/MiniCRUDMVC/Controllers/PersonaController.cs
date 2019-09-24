using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniCRUDMVC.Models;

namespace MiniCRUDMVC.Controllers
{
    public class PersonaController : Controller
    {
        ClasePersonaDB objetoPersona = new ClasePersonaDB();

        //Ejemplo: https://localhost:44320/Persona/Cons_Personas
        public IActionResult Cons_Personas()
        {
            try
            {
                return View(objetoPersona.Cons_Personas().ToList());
            }
            catch (Exception ex)
            {
                return View(new List<ModeloPersonas>());
            }
        }

        //Ejemplo: https://localhost:44320/Persona/Ins_Personas
        public IActionResult Ins_Personas(ModeloPersonas unaPesona)
        {
            try
            {
                objetoPersona.Ins_Personas(unaPesona);
                return View();
            }
            catch (Exception ex)
            {
                return View();
            }
        }

    }
}