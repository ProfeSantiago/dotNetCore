using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ejemplos_Linq
{
    class Program
    {
        static IEnumerable<string> Inicio()
        {
            yield return "Nena";
            yield return "Dale";
            yield return "Toma";
            yield return "Suavemente";
        }

        static IEnumerable<string> Final()
        {
            yield return "encriptamelo";
            yield return "tu lo Formateas";
            yield return "subelo a mi nube";
            yield return "porque tu me pixeleas";
        }

        static void Main(string[] args)
        {
            var laConsulta = from i in Inicio()
                             from f in Final()
                             select new { i, f };

            Console.WriteLine("");
            Console.WriteLine("Regueton Informático");
            Console.WriteLine("");

            foreach (var c in laConsulta)
            {
                Console.WriteLine("{0} {1}", c.i, c.f);
            }

            Console.ReadKey();
            //----------------------------------------------------------------------

            Console.WriteLine("");
            Console.WriteLine("Primeras 6 Canciones");
            Console.WriteLine("");

            var lasPrimeras = laConsulta.Take(6);
           
            foreach (var c in lasPrimeras)
            {
                Console.WriteLine("{0} {1}", c.i, c.f);
            }

            Console.ReadKey();
            //----------------------------------------------------------------------

            Console.WriteLine("");
            Console.WriteLine("Ultimas 6 Canciones");
            Console.WriteLine("");

            var lasUltimas = laConsulta.Skip(10);

            foreach (var c in lasUltimas)
            {
                Console.WriteLine("{0} {1}", c.i, c.f);
            }

            Console.ReadKey();
            //----------------------------------------------------------------------
        }

    }
}
