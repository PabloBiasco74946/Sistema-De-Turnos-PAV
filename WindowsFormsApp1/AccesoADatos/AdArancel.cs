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
    class AdArancel
    {

        public static bool AgregarArancelADB(Arancel ara)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;


            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO aranceles (tipoDocProfesional,numDocProfesional,fecha_Inicio_Vigencia, fecha_Fin_Vigencia, precio)" +
                    " VALUES(@tipoDocProfesional,@numDocProfesional,@fecha_Inicio_Vigencia, @fecha_Fin_Vigencia, @precio )";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fecha_Inicio_Vigencia", ara.FechaDeInicioVigencia);
                cmd.Parameters.AddWithValue("@fecha_Fin_Vigencia", ara.FechaDeInicioVigencia);
                cmd.Parameters.AddWithValue("@precio", ara.PrecioDeArancel);
                cmd.Parameters.AddWithValue("@tipoDocProfesional", ara.TipoDocDeProfesional);
                cmd.Parameters.AddWithValue("@numDocProfesional", ara.NumDocDeProfesional);
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

        public static DataTable ObtenerDatosArancel()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "ObtenerArancel";

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
