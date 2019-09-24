using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfasesCSharp
{
    class Estudiante : Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        private string Carnet;

        public string devuelveNombreCompleto()
        {
            return Nombre + " " + Apellido;
        }

        public string devuelveCarnet()
        {
            return Carnet;
        }

        public void obtieneCarnet(string Id)
        {
            Carnet = Id;
        }

    }//Fin Estudiante
}
