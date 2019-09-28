using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ApiMiniCRUD.Models
{
    public class ClasePersonaDB
    {

        string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=PersonasDB;Integrated Security=True;MultipleActiveResultSets=True";
 
        public IEnumerable<ModeloPersonas> Cons_Personas()
        {
            List<ModeloPersonas> listaPersonas = new List<ModeloPersonas>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Cons_Personas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ModeloPersonas alguien = new ModeloPersonas();
                    alguien.Cedula = rdr["Cedula"].ToString();
                    alguien.Nombre = rdr["Nombre"].ToString();
                    alguien.Telefono = rdr["Telefono"].ToString();
                    alguien.Direccion = rdr["Direccion"].ToString();
                    alguien.Correo = rdr["Correo"].ToString();
                    listaPersonas.Add(alguien);
                }
                con.Close();
            }
            return listaPersonas;
        }//Fin Cons_Personas -------------------------------------

        public void Ins_Personas(ModeloPersonas somguan)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Ins_Personas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cedula", somguan.Cedula);
                cmd.Parameters.AddWithValue("@Nombre", somguan.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", somguan.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", somguan.Direccion);
                cmd.Parameters.AddWithValue("@Correo", somguan.Correo);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }//Fin Ins_Personas -------------------------------------

    }
}
