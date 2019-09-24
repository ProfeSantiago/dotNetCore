using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento_CSharp
{
    class Encapsulamiento
    {

        static void Main(string[] args)
        {
           //Definimos una instancia de la clase libro
            Libro Novela = new Libro();            
            Novela.TituloLibro = "UML y Patrones";
            Console.WriteLine("Titulo: {0}", Novela.TituloLibro);
            Console.ReadKey();
        }

    }
}

