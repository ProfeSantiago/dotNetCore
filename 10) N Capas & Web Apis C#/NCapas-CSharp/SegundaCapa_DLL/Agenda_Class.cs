using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SegundaCapa_DLL
{
    public class Agenda_Class
    {
        private SqlCommand InicializaSQLCommand(string NombreSP)
        {
            string elConnString = "Server=UNIBITECPC\\SQLEXPRESS;Database=PersonasDB;Trusted_Connection=True;";
                //"Data Source=TELETRAN\\SQLEXPRESS;Initial Catalog=Agenda_DB;Integrated Security=True;MultipleActiveResultSets=True";
                  //@"Persist Security Info=True;User ID=sa;Password=;Initial Catalog=Agenda_DB;Data Source=TELETRAN\SQLEXPRESS";
                 //@"Server=TELETRAN\SQLEXPRESS;Database=Agenda_DB;Trusted_Connection=True;";
  
            SqlConnection sqlConnection = new SqlConnection(elConnString);
            SqlCommand sqlCommand = new SqlCommand(NombreSP, sqlConnection)
            {
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            return sqlCommand;
        }//InicializaSQLCommand ============================================

        public Int32 InsertaPersonas(string Cedula, string Nombre, string Telefono, string Direccion, string Correo)
        {
            SqlCommand sqlCommand = new SqlCommand();
            Int32 FilasAfectadas = 0;
            try
            {
                sqlCommand = InicializaSQLCommand("Ins_Personas");

                sqlCommand.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = Cedula;
                sqlCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre;
                sqlCommand.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = Telefono;
                sqlCommand.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Direccion;
                sqlCommand.Parameters.Add("@Correo", SqlDbType.VarChar).Value = Correo;

                sqlCommand.Connection.Open();
                FilasAfectadas = sqlCommand.ExecuteNonQuery();
                return FilasAfectadas;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlCommand.Connection.Close();
                sqlCommand.Dispose();
            }
        }//InsertaPersonas

        public DataSet ConsultaPersonas()
        {
            SqlCommand sqlCommand = new SqlCommand();
            var adapter = new SqlDataAdapter();
            var Registro = new DataSet();
            try
            {
                sqlCommand = InicializaSQLCommand("Cons_Personas");
                sqlCommand.Connection.Open();

                adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(Registro);
                return Registro;
            }
            catch (Exception e)
            {
                e.ToString();
                throw;
            }
            finally
            {
                sqlCommand.Connection.Close();
                sqlCommand.Dispose();
            }
        }//ConsultaPersonas
    
    }//Fin Agenda_Class
}
