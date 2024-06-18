// Api que vamos a llamar:
// https://jsonplaceholder.typicode.com/posts
//
namespace WebApiClientConsoleParse
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
                //HTTP GET
                var responseTask = client.GetAsync("posts");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<ApiDatos[]>();
                    readTask.Wait();

                    var TodosLosApiDatos = readTask.Result;

                    foreach (var datoJSON in TodosLosApiDatos)
                    {
                        Console.WriteLine(datoJSON.title);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}