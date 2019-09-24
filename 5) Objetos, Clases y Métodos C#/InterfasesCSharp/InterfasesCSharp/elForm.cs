using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfasesCSharp
{
    public partial class elForm : Form
    {
        Estudiante Alumno = new Estudiante();
        Profesor elProfe = new Profesor();

        public elForm()
        {
            InitializeComponent();
        }

        private void MustraBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(elProfe.devuelveCedula() + " \n " + elProfe.devuelveNombreCompleto());
        }

        private void elForm_Load(object sender, EventArgs e)
        {
            //Cargamos las variables con datos

            elProfe.Nombre = "Allan";
            elProfe.Apellido = "Turing";
            elProfe.obtieneCedula("000000");

            Alumno.Nombre = "Kung-Fu";
            Alumno.Apellido = "Panda";
            Alumno.obtieneCarnet("123456");
        }
    }
}
