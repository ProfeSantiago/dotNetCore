//---------------------------------------------
// Para correr este ejemplo visitar:
// http://localhost:5041/Persona (El puerto cambia en cada dispositivo)
//---------------------------------------------

using Microsoft.AspNetCore.Mvc;
using WebApiSimple.Models;

namespace WebApiSimple.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonaController : Controller
    {
        [HttpGet(Name = "Persona")]
        public IActionResult Index()
        {
            List<Persona> ListaPersonas = new List<Persona>
            {
                new Persona { ID = 1, Nombre = "Leonardo", Telefono = "1111-1111" },
                new Persona { ID = 2, Nombre = "Donatello", Telefono = "2222-2222" },
                new Persona { ID = 3, Nombre = "Miguel Angel", Telefono = "3333-3333" },
                new Persona { ID = 4, Nombre = "Rafael", Telefono = "4444-4444" },
            };

            return Json(ListaPersonas);
        }
    }
}
