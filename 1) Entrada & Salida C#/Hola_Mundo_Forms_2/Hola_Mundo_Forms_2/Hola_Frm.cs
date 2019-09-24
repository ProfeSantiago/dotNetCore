using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hola_Mundo_Forms_2
{
    public partial class Hola_Frm : Form
    {
        public Hola_Frm()
        {
            InitializeComponent();
        }

        private void Saluda_Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola tu nombre es: "+Nombre_Txt.Text);
        }
    }
}
