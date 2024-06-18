// Api que vamos a llamar:
// https://jsonplaceholder.typicode.com/posts

HttpClient client = new()
{
    BaseAddress = new Uri("https://jsonplaceholder.typicode.com/")
};

var response = await client.GetAsync("posts/1");
var content = await response.Content.ReadAsStringAsync();
Console.WriteLine("Datos del primer Api:");
Console.WriteLine(content);
Console.WriteLine();
Console.WriteLine("°-°-°-°-°-°-°-°-°-°-°-°-°-°-°-°-°-°-°-°-°-°-°-°-°-°-°-°-°-°");
Console.WriteLine();

//---------------------------------------------------------------
// Api que vamos a llamar:
// https://api.coindesk.com/v1/bpi/currentprice.json

HttpClient client2 = new()
{
    BaseAddress = new Uri("https://api.coindesk.com/v1/bpi/")
};

var response2 = await client2.GetAsync("currentprice.json");
var content2 = await response2.Content.ReadAsStringAsync();
Console.WriteLine("Datos del segundo Api:");
Console.WriteLine(content2);
Console.WriteLine();
//---------------------------------------------------------------