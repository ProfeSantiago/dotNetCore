//---------------------------------------------
// Api que vamos a llamar:
// http://localhost:5041/Persona (El puerto cambia en cada dispositivo)
//
// Para correr este ejemplo visitar:
// https://localhost:7063/ (El puerto cambia en cada dispositivo)
//---------------------------------------------
using ClienteApiSimple.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http.Headers;
using WebApiSimple.Models;

namespace ClienteApiSimple.Controllers
{
    public class HomeController : Controller
    {
        string Baseurl = " http://localhost:5041/";
        public async Task<ActionResult> Index()
        {
            List<Persona> DatosJSON = new List<Persona>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("Persona");

                if (Res.IsSuccessStatusCode)
                {
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                    DatosJSON = JsonConvert.DeserializeObject<List<Persona>>(EmpResponse);
                }
                return View(DatosJSON);
            }
        }
    }
}
