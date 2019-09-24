using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicional_If_Else
{
    public partial class Condicionales_Frm : Form
    {
        public Condicionales_Frm()
        {
            InitializeComponent();
        }

        private void Ingresa_Btn_Click(object sender, EventArgs e)
        {
            if (int.Parse(Edad_Txt.Text) < 18)
            {
                MessageBox.Show("Es menor de edad no puede ingresar");
            }
            else
            {
                MessageBox.Show("Bienvenid@: " + Nombre_Txt.Text +" Puedes ingresar" );
            }

        }
    }
}
