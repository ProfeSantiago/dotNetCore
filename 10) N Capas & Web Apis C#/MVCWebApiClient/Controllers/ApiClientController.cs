//---------------------------------------------
// Api que vamos a llamar:
// https://jsonplaceholder.typicode.com/posts
//
// Para correr este ejemplo visitar:
// http://localhost:5230/ApiClient (El puerto cambia en cada dispositivo)
//---------------------------------------------

using Microsoft.AspNetCore.Mvc;
using MVCWebApiClient.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace MVCWebApiClient.Controllers
{
    public class ApiClientController : Controller
    {
        string Baseurl = "https://jsonplaceholder.typicode.com/";
        public async Task<ActionResult> Index()
        {
            List<ApiDatos> DatosJSON = new List<ApiDatos>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("posts");

                if (Res.IsSuccessStatusCode)
                {
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                    DatosJSON = JsonConvert.DeserializeObject<List<ApiDatos>>(EmpResponse);
                }
                return View(DatosJSON);
            }
        }
    }
}