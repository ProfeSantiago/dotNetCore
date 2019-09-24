using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCapas_CSharp
{
    public partial class Agenda_Frm : Form
    {
        public Agenda_Frm()
        {
            InitializeComponent();
        }

        private void Agenda_Frm_Load(object sender, EventArgs e)
        {
            var MiDataSet = new DataSet();
            var MiDLL = new SegundaCapa_DLL.Agenda_Class();
            MiDataSet = MiDLL.ConsultaPersonas();

            //dataGridView1.DataSource = MiDataSet.Tables[0];
            //dataGridView1.Refresh();

            //-----------------------------------------------------------
            List<ModeloPersonas> ListaPersonas = new List<ModeloPersonas>();
            foreach (DataRow dr in MiDataSet.Tables[0].Rows)
            {
                ListaPersonas.Add(new ModeloPersonas
                {
                    Cedula = dr["Cedula"].ToString(),
                    Nombre = dr["Nombre"].ToString(),
                    Telefono = dr["Telefono"].ToString(),
                    Direccion = dr["Direccion"].ToString(),
                    Correo = dr["Correo"].ToString()
                });
            }//Fin foreach

            dataGridView1.DataSource = ListaPersonas;
            dataGridView1.Refresh();


            ////-----------------------------------------------------------
            //List<ModeloPersonas> OrdenadosDesc = ListaPersonas.OrderByDescending(s => s).ToList();

            //foreach (ModeloPersonas item in OrdenadosDesc)
            //{
            //    listBox1.Items.Add(item.Nombre);
            //}
           

        }
    }
}
