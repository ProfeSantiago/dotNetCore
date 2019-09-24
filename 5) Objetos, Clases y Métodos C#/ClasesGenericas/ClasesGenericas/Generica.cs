using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas
{
    class Generica<T>
   {
      private T[] elArreglo;

      public Generica(int size)
      {
         elArreglo = new T[size + 1];
      }
      
      public T ConsultaElemento(int Indice)
      {
         return elArreglo[Indice];
      }

      //public T[] ConsultaTodos()
      //{
      //    return elArreglo;
      //}

      public void GuardaElemento(int Indice, T Valor)
      {
          elArreglo[Indice] = Valor;
      }
    }
}
