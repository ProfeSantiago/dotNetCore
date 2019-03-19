using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MiniCrudRazor.Models;

namespace MiniCrudRazor.Pages
{
    public class Ins_PersonasModel : PageModel
    {
        ClasePersonaDB ObjetoPersonaDB = new ClasePersonaDB();

        [BindProperty]
        public ModeloPersonas sombari { get; set; }

        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ObjetoPersonaDB.Ins_Personas(sombari);

            return RedirectToPage("./Cons_Personas");
        }
    }
}