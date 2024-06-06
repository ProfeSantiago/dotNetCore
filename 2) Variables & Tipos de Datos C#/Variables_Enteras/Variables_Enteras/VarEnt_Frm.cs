using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables_Enteras
{
    public partial class VarEnt_Frm : Form
    {
        int A, B, C;

        public VarEnt_Frm()
        {
            InitializeComponent();
        }

        private void VarEnt_Frm_Load(object sender, EventArgs e)
        {
            A = 0;
            B = 0;
            C = 0;
        }

        private void Suma_Btn_Click(object sender, EventArgs e)
        {
            //Leemos de pantalla los 2 valores
            A = int.Parse(Num1_Txt.Text);
            B = int.Parse(Num2_Txt.Text);

              //Le asignamos a "C" el resultado de la suma de A+B
            C = A + B;

            //Mostramos en pantalla el valor de "C"
            Resultado_Txt.Text = C.ToString();
        }

        
    }
}
