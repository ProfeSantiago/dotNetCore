using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro2Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona[] lasPersonas = {
                new Persona { ID = 1, Nombre = "Mafalda", Telefono = "1111-0001" },
                new Persona { ID = 2, Nombre = "Manolito", Telefono = "2222-0002" },
                new Persona { ID = 3, Nombre = "Miguelito", Telefono = "3333-3333" },
                new Persona { ID = 4, Nombre = "Susanita", Telefono = "4444-0004" }
            };

            string[] listaNombres = { "Tiger", "Bombom", "Dexter",
                       "Papa Smurf", "Megatron", "He-Man", "Chavo",
                       "Hello Kitty", "Robin" , "Mafalda", "Susanita"};

            var consultaJoin = listaNombres.GroupJoin(lasPersonas, n => n, p => p.Nombre,
                 (n, matching) => new { Nombresillo = n, SeRepite = matching.Count() });

            Console.WriteLine("Elementos repetidos en Ambos Arreglos");
            Console.WriteLine("");

            foreach (var item in consultaJoin)
                Console.WriteLine(item);

           
            Console.ReadKey();
        }
    }
}
