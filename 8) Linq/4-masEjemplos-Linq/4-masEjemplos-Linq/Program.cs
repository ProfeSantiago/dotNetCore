using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_masEjemplos_Linq
{
    class Program
    {

        class Empleado
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
        }

        class Puesto
        {
            public string NombrePuesto { get; set; }
            public int Experiencia { get; set; }
        }

        static void Main(string[] args)
        {
            ArrayList coleccionCosas = new ArrayList(5);
            coleccionCosas.Add("Espada del Augurio");
            coleccionCosas.Add("El tractor del pollito Pío");
            coleccionCosas.Add(3.14);
            coleccionCosas.Add(0.50);
            coleccionCosas.Add("El martillo de Homero");

            IEnumerable<string> laConsultaTexto = coleccionCosas.OfType<string>();
            IEnumerable<double> laConsultaNumeros = coleccionCosas.OfType<double>();

            Console.WriteLine("");
            Console.WriteLine("Lista de Cosas del Armario");
            Console.WriteLine("");

            Console.WriteLine("Elementos de tipo Texto:");

            foreach (var c in laConsultaTexto)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("");
            Console.WriteLine("Elementos numéricos:");

            foreach (var c in laConsultaNumeros)
            {
                Console.WriteLine(c);
            }

            Console.ReadKey();
            //----------------------------------------------------------------------

            List<Empleado> listaEmpleados = new List<Empleado>()
            {
                new Empleado(){Nombre="Don Ramón", Edad=50},
                new Empleado(){Nombre="Viviana Calderón", Edad=38},
                new Empleado(){Nombre="Luis Cemento Solis", Edad=60},
            };

            List<Puesto> listaPuestos = new List<Puesto>()
            {
                new Puesto{NombrePuesto="Reparando zapatos en la vecindad", Experiencia=5},
                new Puesto{NombrePuesto="Vendiendo Cemento Chino", Experiencia=2},
                new Puesto{NombrePuesto="Presentando el programa: Robando por un Sueño", Experiencia=10},
            };

            var consultaCrossJoin =
            from e in listaEmpleados
            from p in listaPuestos
            select new { e.Nombre, p.Experiencia, p.NombrePuesto };

            Console.WriteLine("");
            Console.WriteLine("Ejemplo de Cross Join:");
            Console.WriteLine("");

            foreach (var x in consultaCrossJoin)
            {
                Console.WriteLine("{0,-5}, {1} años, {2}", x.Nombre, x.Experiencia, x.NombrePuesto);
            }

            Console.ReadKey();
            //----------------------------------------------------------------------

        }
    }
}
