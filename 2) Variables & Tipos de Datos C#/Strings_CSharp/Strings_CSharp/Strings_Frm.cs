using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings_CSharp
{
    public partial class Strings_Frm : Form
    {
        public Strings_Frm()
        {
            InitializeComponent();
        }

        private void Procesar_Btn_Click(object sender, EventArgs e)
        {
            //Leemos de pantalla y guardamos en la variable: texto
            string texto = Palabra_Txt.Text;

            //Contamos las letras del texto
            int CantLetras = texto.Length;

            if (CantLetras >= 2)
            {
                Primera_Txt.Text = texto.Substring(0, 1);

                Ultima_Txt.Text = texto.Substring(CantLetras - 1, 1);

                Cantidad_Txt.Text = CantLetras.ToString();

            }//Fin If
        }
    }
}
