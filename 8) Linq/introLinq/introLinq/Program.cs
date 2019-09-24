using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listaNombres = { "Buzz lightyear", "John Connor", "Kal-El",
                       "James Tiberious Kirk", "Pocoyo", "Robocop", "Joker",
                       "Hulk", "Bananero" };

            IEnumerable<string> soloNombresCortos = from s in listaNombres where s.Length <= 7
                                                    orderby s select s.ToUpper();

            Console.WriteLine("Nombres Cortos");
            Console.WriteLine("");

            foreach (string item in soloNombresCortos)
                Console.WriteLine(item);

            
            //----------------------------------------------------------------------
            Console.WriteLine("");
            Console.WriteLine("Nombres con que empiezan con 'J'");
            Console.WriteLine("");

            string[] empiezanConJota = listaNombres.Where(s => s[0] == 'J').ToArray();

            foreach (string item in empiezanConJota)
                Console.WriteLine(item);

            
            //----------------------------------------------------------------------
            Console.WriteLine("");
            Console.WriteLine("Nombres Ordenados Alfabeticamente");
            Console.WriteLine("");

            var Ordenados = listaNombres.OrderBy(s => s);
            var OrdenadosDesc = listaNombres.OrderByDescending(s => s);

            foreach (string item in Ordenados)
                Console.WriteLine(item);

            
            //----------------------------------------------------------------------
            Console.WriteLine("");
            Console.WriteLine("Nombres Ordenados por Tamaño");
            Console.WriteLine("");


            var Tamagno = listaNombres.OrderBy(s => s.Length);
            var TamagnoDesc = listaNombres.OrderByDescending(s => s.Length);

            foreach (string item in TamagnoDesc)
                Console.WriteLine(item);

            
            //----------------------------------------------------------------------
            Console.WriteLine("");
            Console.WriteLine("Nombres Ordenados Alfabéticamente y luego por Tamaño");
            Console.WriteLine("");
                        
            var ConsultaOrdenada = listaNombres.OrderBy(s => s).ThenBy(s => s.Length);

            foreach (string item in ConsultaOrdenada)
                Console.WriteLine(item);


            //----------------------------------------------------------------------
            Console.WriteLine("");
            Console.WriteLine("Nombres Agrupados por Tamaño");
            Console.WriteLine("");

            var groups = listaNombres.GroupBy(s => s.Length);

            foreach (IGrouping<int, string> group in groups)
            {
                Console.WriteLine("Nombres de Longitud: {0}", group.Key);

                foreach (string value in group)
                    Console.WriteLine("  {0}", value);
            }

            //----------------------------------------------------------------------
            Console.ReadLine();
        }
    }
}
