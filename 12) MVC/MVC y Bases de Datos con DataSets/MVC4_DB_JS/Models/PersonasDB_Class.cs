using System;
using System.Data;
using System.Data.SqlClient;

namespace MVC4_DB_JS.Models
{
    public class PersonasDB_Class
    {
        private string ObtieneConnString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["PersonasConnectString"].ConnectionString;

        }//ObtieneConnString

        private SqlCommand InicializaSQLCommand(string NombreSP)
        {
            SqlConnection sqlConnection = new SqlConnection(ObtieneConnString());
            SqlCommand sqlCommand = new SqlCommand(NombreSP, sqlConnection)
            {
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            return sqlCommand;

        }//InicializaSQLCommand

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

     
    }//PersonasDB_Class
}