using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfasesCSharp
{
    class Profesor : Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        private string Cedula;

        public string devuelveNombreCompleto()
        {
            return Nombre + " " + Apellido;
        }

        public string devuelveCedula()
        {
            return Cedula;
        }

        public void obtieneCedula(string Ced)
        {
            Cedula = Ced;
        }
     
    }//Fin Profesor
}
