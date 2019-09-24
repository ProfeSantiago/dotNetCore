using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos
{
    public partial class Arreglos_Frm : Form
    {
        //Declaración de Variables
        int Contador, nuevoNumero;
        int[] ArregloNumeros = new int[10];

        public Arreglos_Frm()
        {
            InitializeComponent();
        }

        private void Arreglos_Frm_Load(object sender, EventArgs e)
        {

        }

        private void Agrega_Btn_Click(object sender, EventArgs e)
        {
            //Leemos de pantalla
            nuevoNumero = int.Parse(Numero_Txt.Text);

            //Agregamos el número al Arreglo
            if (Contador < 10)
            {
                ArregloNumeros[Contador] = nuevoNumero;
                Contador++;
            }else{
                Contador = 0;
               MessageBox.Show("Has exedido el limite del arreglo");
            }

            //Limpiamos el ListBox
            ListaNums_ListBox.Items.Clear();

            //Recorremos el Arreglo
            for (int i = 0; i < 10; i++)
            {
                //Agregamos el número al ListBox
                ListaNums_ListBox.Items.Add(ArregloNumeros[i]);
            }           

            //Limpiamos el campo de texto
            Numero_Txt.Text = "";
        }

    }
}
