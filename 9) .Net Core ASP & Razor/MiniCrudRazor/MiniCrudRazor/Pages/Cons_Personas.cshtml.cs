using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MiniCrudRazor.Models;

namespace MiniCrudRazor.Pages
{
    public class Cons_PersonasModel : PageModel
    {
        ClasePersonaDB ObjetoPersonaDB = new ClasePersonaDB();
        public List<ModeloPersonas> listaPersonas = new List<ModeloPersonas>();

        public void OnGet()
        {
            listaPersonas = ObjetoPersonaDB.Cons_Personas().ToList();       
        }
    }
}