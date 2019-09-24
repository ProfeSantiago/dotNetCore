using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos_Ordenamiento
{
    public partial class Ordenamientos_Frm : Form
    {
        //Declaración de Variables
        int Contador, nuevoNumero, valorTemporal;
        int[] ArregloNumeros = new int[10];
        int[] ArregloBurbuja = new int[10];

        public Ordenamientos_Frm()
        {
            InitializeComponent();
        }

        private void Ordenamientos_Frm_Load(object sender, EventArgs e)
        {

        }

        public void Inserta(int Numero)
        {
            //Agregamos el número al Arreglo
            if (Contador < 10)
            {
                ArregloNumeros[Contador] = Numero;
                Contador++;
            }
            else
            {
                Contador = 0;
                MessageBox.Show("Has exedido el limite del arreglo");
            }//else
        }//Inserta

        public void Llena_Lista(int[] ArregloNums)
        {
            //Limpiamos el ListBox
            ListaNums_ListBox.Items.Clear();

            //Recorremos el Arreglo
            for (int i = 0; i < 10; i++)
            {
                //Agregamos el número al ListBox
                ListaNums_ListBox.Items.Add(ArregloNums[i]);
            }
        }//Llena_Lista

        public void Ordena_Burbuja(int[] ArregloBurbuja)
        {
            //Este For es el que llama N veces al For que ordena
            for (int pasadas = 1; pasadas < ArregloBurbuja.Length; pasadas++)
            {
                //Este For es el que ordena
                for (int i = 0; i < ArregloBurbuja.Length - 1; i++)
                {
                    if (ArregloBurbuja[i] > ArregloBurbuja[i + 1])
                    {
                        valorTemporal = ArregloBurbuja[i];
                        ArregloBurbuja[i] = ArregloBurbuja[i + 1];
                        ArregloBurbuja[i + 1] = valorTemporal;
                    }
                }//For #2
            }//For #1

            Llena_Lista(ArregloBurbuja);
        }//Ordena_Burbuja

        public int Particion(int[] ArregloQuickSort, int left, int right)
        {
            int pivot = ArregloQuickSort[left];
            while (true)
            {
                while (ArregloQuickSort[left] < pivot)
                    left++;

                while (ArregloQuickSort[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = ArregloQuickSort[right];
                    ArregloQuickSort[right] = ArregloQuickSort[left];
                    ArregloQuickSort[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }//Particion

        struct QuickPosInfo
        {
            public int left;
            public int right;
        };

        public void QuickSort(int[] ArregloQuickSort, int left, int right)
        {

            if (left >= right)
                return; // Invalid index range

            List<QuickPosInfo> list = new List<QuickPosInfo>();

            QuickPosInfo info;
            info.left = left;
            info.right = right;
            list.Insert(list.Count, info);

            while (true)
            {
                if (list.Count == 0)
                    break;

                left = list[0].left;
                right = list[0].right;
                list.RemoveAt(0);

                int pivot = Particion(ArregloQuickSort, left, right);

                if (pivot > 1)
                {
                    info.left = left;
                    info.right = pivot - 1;
                    list.Insert(list.Count, info);
                }

                if (pivot + 1 < right)
                {
                    info.left = pivot + 1;
                    info.right = right;
                    list.Insert(list.Count, info);
                }
            }

            Llena_Lista(ArregloQuickSort);
        }//QuickSort

        private void Agrega_Btn_Click(object sender, EventArgs e)
        {
            //Leemos de pantalla
            nuevoNumero = int.Parse(Numero_Txt.Text);

            Inserta(nuevoNumero);
           
            Llena_Lista(ArregloNumeros);         

            //Limpiamos el campo de texto
            Numero_Txt.Text = "";

            Numero_Txt.Focus();
            Numero_Txt.Select();
        }

        private void Burbuja_Btn_Click(object sender, EventArgs e)
        {
            Ordena_Burbuja(ArregloNumeros); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuickSort(ArregloNumeros, 0, ArregloNumeros.Length - 1); 
        }
    }
}
