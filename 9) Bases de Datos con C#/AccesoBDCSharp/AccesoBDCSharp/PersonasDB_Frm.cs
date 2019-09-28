using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoBDCSharp
{
    public partial class PersonasDB_Frm : Form
    {      
        public PersonasDB_Frm()
        {
            InitializeComponent();
        }//Fin Constructor

        private void PersonasDB_Frm_Load(object sender, EventArgs e)
        {
            //Declaración de Variables
            DataSet MiDataSet = new DataSet();

            //Creamos una instancia de la clase que llama a los SP
            PersonasDB_Class ObjetoPersonas = new PersonasDB_Class();

            //Cargamos en el DataSet la tabla de personas
            MiDataSet = ObjetoPersonas.ConsultaPersonas();

            //Rellenamos el DataGridView con la Tabla que esta en el DataSet
            elGrid.DataSource = MiDataSet.Tables[0];
        }
    }
}
