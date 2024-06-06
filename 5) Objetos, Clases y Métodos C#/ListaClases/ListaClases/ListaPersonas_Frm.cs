using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaClases
{
    public partial class ListaPersonas_Frm : Form
    {

        List<Persona> ListaPersonas = new List<Persona> { };

        public ListaPersonas_Frm()
        {
            InitializeComponent();
        }

        private void LlenaTabla()
        {
            ConsultaPersonas_Grid.DataSource = null;
            ConsultaPersonas_Grid.Refresh();
            ConsultaPersonas_Grid.DataSource = ListaPersonas;
        }//Fin LlenaTabla
        
        private void ListaPersonas_Frm_Load(object sender, EventArgs e)
        {
            ListaPersonas = new List<Persona>
            {
                new Persona { ID = 1, Nombre = "Mafalda", Telefono = "1111-0001" },
                new Persona { ID = 2, Nombre = "Manolito", Telefono = "2222-0002" },
                new Persona { ID = 3, Nombre = "Miguelito", Telefono = "3333-3333" },
                new Persona { ID = 4, Nombre = "Susanita", Telefono = "4444-0004" }
            };

            LlenaTabla();
        }//ListaPersonas_Frm_Load


        private void Guarda_Btn_Click(object sender, EventArgs e)
        {
            Persona PersonaTemporal = new Persona
            {
                ID = Convert.ToInt32(Id_Txt.Text),
                Nombre = Nom_Txt.Text,
                Telefono = Tel_Txt.Text
            };
            ListaPersonas.Add(PersonaTemporal);

            LlenaTabla();

            
        }





    }//Fin ListaPersonas_Frm
}
