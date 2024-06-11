//---------------------------------------------------------
//Para crear esta App se uso este comando en la terminal:
//dotnet new console --framework net8.0 --use-program-main

//Para compilar esta app hay que usar este comando:
//dotnet build 

//Y para correr esta App se usa este comndo:
//dotnet run
//---------------------------------------------------------
using System;
namespace Consola_VSCode;

class Program
{
    static void Main(string[] args)
    {
        var fechActual = DateTime.Now;
        string nombreArchivo = @"C:\Temp\prueba.txt";
        
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Último inicio de sesión previo:");

        //-------------------------------------------------------------
        // Abrimos el archivo de texto y lo mostramos en pantalla
        //-------------------------------------------------------------
        using (StreamReader sr = File.OpenText(nombreArchivo))
        {
            string lineaLeida = System.String.Empty;
            while ((lineaLeida = sr.ReadLine()) != null)
            {
                Console.WriteLine(lineaLeida);
            }
        }
        //-------------------------------------------------------------

        Console.WriteLine("---------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Digite su nombre de usuario:");
        var nombreUsuario = Console.ReadLine();
        Console.WriteLine("Digite su contraseña:");
        var password = Console.ReadLine();       
        var login = $"{Environment.NewLine} El usuario: "+ nombreUsuario +", inició sesión el día: "+ fechActual+"!";
        Console.WriteLine(login);
        Console.Write($"{Environment.NewLine} Presione una tecla para guardar y salir...");
        Console.ReadKey(true);
        Console.WriteLine();

        //-------------------------------------------------------------
        //Escribimos en el Archivo de texto
        //-------------------------------------------------------------                
        try
        {
            using (StreamWriter sw = File.CreateText(nombreArchivo))
            {
               sw.WriteLine(login);
               sw.Close();
            }
        }        
        catch (Exception Ex)
        {
            Console.WriteLine("Exception: " + Ex.Message);
        }
    }
}
