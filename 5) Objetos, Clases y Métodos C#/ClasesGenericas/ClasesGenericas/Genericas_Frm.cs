using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesGenericas
{
    public partial class Genericas_Frm : Form
    {

        Generica<Estudiante> intArray = new Generica<Estudiante>(5);

        public Genericas_Frm()
        {
            InitializeComponent();
        }

        private void LlenaTabla()
        {
            ConsultaPersonas_Grid.DataSource = null;
            ConsultaPersonas_Grid.Refresh();
            //ConsultaPersonas_Grid.DataSource = ListaPersonas;
        }//Fin LlenaTabla

        private void Guarda_Btn_Click(object sender, EventArgs e)
        {
            if (RadioBtn_Alumno.Checked) { 
            
            }

            if (RadioBtn_Profe.Checked)
            {

            }
        }
    }
}
