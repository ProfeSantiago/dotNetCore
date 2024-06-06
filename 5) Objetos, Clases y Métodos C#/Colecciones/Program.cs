
Dictionary<string, string> paradigmas =
    new Dictionary<string, string>();

paradigmas.Add("Funcional", "Lisp");
paradigmas.Add("Logico", "Prolog");
paradigmas.Add("OO", "SmallTalk");
paradigmas.Add("Imperativo", "C");
paradigmas.Add("Visual", "App Inventor");

Console.WriteLine("Lenguaje Orientado a Objetos => value = {0}", paradigmas["OO"]);
Console.WriteLine("Lenguaje Visual => value = {0}", paradigmas["Visual"]);


//-------------------------------------------------------
Dictionary<string, string>.KeyCollection columnaLlaves =
    paradigmas.Keys;

Console.WriteLine();
Console.WriteLine("Lista de Llaves:");
Console.WriteLine();
foreach (string s in columnaLlaves)
{
    Console.WriteLine("Llave = {0}", s);
}

//-------------------------------------------------------
Dictionary<string, string>.ValueCollection columnaValores =
    paradigmas.Values;

Console.WriteLine();
Console.WriteLine("Lista de Valores:");
Console.WriteLine();
foreach (string s in columnaValores)
{
    Console.WriteLine("Valor = {0}", s);
}





