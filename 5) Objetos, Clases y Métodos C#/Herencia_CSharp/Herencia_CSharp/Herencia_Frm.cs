using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_CSharp
{
    class Herencia_Frm
    {
        static void Main(string[] args)
        {
            //Definimos una instancia de la clase Enciclopedia
            Enciclopedia Oceano = new Enciclopedia();
            Oceano.TituloLibro = "Atlas";
            Console.WriteLine("Titulo: {0}", Oceano.TituloLibro);
            Console.ReadKey();
        }

    }
}
