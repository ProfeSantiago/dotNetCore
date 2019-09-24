using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_CSharp
{
    class Libro
    {
        protected string Titulo;
        protected string Autor;
        protected int numeroDePaginas;

        //Constructores
        public Libro() { }
        public Libro(string titu, string aut, int paginas) {
            Titulo = titu;
            Autor = aut;
            numeroDePaginas = paginas;
        }

        //Este metodo sera reemplazado en la clase derivada
        public virtual void muestraDatos()
        {
            Console.WriteLine("Titulo: {0}", Titulo);
            Console.WriteLine("Autor: {0}", Autor);
            Console.WriteLine("Páginas: {0}", numeroDePaginas);
            Console.ReadKey();
        }

        //Propiedades
        public string GetTitulo()
        {
            return Titulo;
        }

        public string TituloLibro
        {
            get{return Titulo;}
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! El título debe tener menos de 16 letras");
                }
                else
                {
                    Titulo = value;
                }
            }
        }//TituloLibro

    }//Class Libro

}
