using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_CSharp 
{
    sealed class Enciclopedia : Libro
    {
        private int numeroDeTomos;

        public override void muestraDatos()
        {
            Console.WriteLine("Titulo: {0}", Titulo);
            Console.WriteLine("Autor: {0}", Autor);
            Console.WriteLine("Páginas: {0}", numeroDePaginas);
            Console.WriteLine("Tomos: {0}", numeroDeTomos);
            Console.ReadKey();
        }
    }
}
