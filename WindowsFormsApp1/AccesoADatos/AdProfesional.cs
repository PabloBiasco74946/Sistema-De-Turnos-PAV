using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entidades;


namespace WindowsFormsApp1.AccesoADatos
{
    class AdProfesional
    {

        public static bool AgregarProfesionalADB(Profesional pro)
        {


            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO profesionales (tipoDoc, numDoc, nombre, apellido, email, telefono, fecha_Nacimiento, matricula_Cirujano) " +
                    "VALUES(@tipoDoc, @numDoc, @nombre, @apellido, @email, @telefono, @fecha_Nacimiento, @matricula_Cirujano)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDoc", pro.TipoDocumentoProfesional);
                cmd.Parameters.AddWithValue("@numDoc", pro.NumeroDeDocumentoProfesional);
                cmd.Parameters.AddWithValue("@nombre", pro.NombreProfesional);
                cmd.Parameters.AddWithValue("@apellido", pro.ApellidoProfesional);
                cmd.Parameters.AddWithValue("@email", pro.EmailProfesional);
                cmd.Parameters.AddWithValue("@telefono", pro.TelefonoProfesional);
                cmd.Parameters.AddWithValue("@fecha_Nacimiento", pro.FechaNacimientoProfesional);
                cmd.Parameters.AddWithValue("@matricula_Cirujano", pro.MatriculaProfesional);
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


        public static DataTable ObtenerDatosProfesional()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "ObtenerProfesionales";

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

        //Nos costó mucho :(
        public static bool EliminarProfesional(Profesional pro)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE profesionales WHERE numDoc = @numDoc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@numDoc", pro.NumeroDeDocumentoProfesional);
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
    }
}
