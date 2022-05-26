using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.AccesoADatos
{
    class AdClinica
    {
        public static bool AgregarClinicaADB(Clinica cli)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO clinicas (nombre,id_Barrio,razonSocial,calle, numero)" +
                    " VALUES(@nombre,@id_Barrio,@razonSocial,@calle, @numero )";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", cli.NombreDeClinica);
                cmd.Parameters.AddWithValue("@id_Barrio", cli.IdDeBarrio);
                cmd.Parameters.AddWithValue("@razonSocial", cli.RazonDeClinica);
                cmd.Parameters.AddWithValue("@calle", cli.CalleClinica);
                cmd.Parameters.AddWithValue("@numero", cli.NumeroDeClinica);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static DataTable ObtenerDatosClinica()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "ObtenerDatosClinicas";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;


                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

    }
}
