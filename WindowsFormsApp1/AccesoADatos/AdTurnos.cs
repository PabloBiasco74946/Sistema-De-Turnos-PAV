using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.AccesoADatos
{
    class AdTurnos
    {

        public static bool AltaNuevoTurno(int idTurno,string NombreProfesional, string ApellidoProfesional, string NombrePaciente,
            string ApellidoPaciente, int NumDocProfesional, int TipoDocProfesional, int NumDocPaciente, 
            int TipoDocPaciente, int ObraSocial, int Precio, int Especialidad, DateTime FechaTurno)

 

        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlTransaction ObjTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO turnos values(@nombreProfesional, @apellidoProfesional, " +
                    "@nombrePaciente,@apellidoPaciente,@numDocProfesional," +
                    "@tipoDocProfesional,@numDocPaciente,@tipoDocPaciente,@fechaTurno,@obraSocial,@precio,@Especialidad)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreProfesional", NombreProfesional);
                cmd.Parameters.AddWithValue("@apellidoProfesional", ApellidoProfesional);
                cmd.Parameters.AddWithValue("@nombrePaciente", NombrePaciente);
                cmd.Parameters.AddWithValue("@apellidoPaciente", ApellidoPaciente);
                cmd.Parameters.AddWithValue("@numDocProfesional", NumDocProfesional);
                cmd.Parameters.AddWithValue("@tipoDocProfesional", TipoDocProfesional);
                cmd.Parameters.AddWithValue("@numDocPaciente", NumDocPaciente);
                cmd.Parameters.AddWithValue("@tipoDocPaciente", TipoDocPaciente);
                cmd.Parameters.AddWithValue("@fechaTurno", FechaTurno);
                cmd.Parameters.AddWithValue("@obraSocial", ObraSocial);
                cmd.Parameters.AddWithValue("@precio", Precio);
                cmd.Parameters.AddWithValue("@Especialidad", Especialidad);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();

                ObjTransaccion = cn.BeginTransaction("AltaDeTurno");

                cmd.Transaction = ObjTransaccion;

                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                string consultaTurnoXpaciente = "INSERT INTO turnos_X_Paciente values (@pacienteTipoDoc, @pacienteNroDoc,@idEspecialidad,@tipoDocEspecialista," +
                    "@numDocEspecialista,@fechaDeTurno,@idTurno,@obraSocial,@precio)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@pacienteTipoDoc", TipoDocPaciente);
                cmd.Parameters.AddWithValue("@pacienteNroDoc", NumDocPaciente);
                cmd.Parameters.AddWithValue("@idEspecialidad", Especialidad);
                cmd.Parameters.AddWithValue("@tipoDocEspecialista", TipoDocProfesional);
                cmd.Parameters.AddWithValue("@numDocEspecialista", NumDocProfesional);
                cmd.Parameters.AddWithValue("@fechaDeTurno", FechaTurno);
                cmd.Parameters.AddWithValue("@idTurno", idTurno);
                cmd.Parameters.AddWithValue("@obraSocial", ObraSocial);
                cmd.Parameters.AddWithValue("@precio", Precio);

                cmd.CommandText = consultaTurnoXpaciente;
                cmd.ExecuteNonQuery();

                ObjTransaccion.Commit();
                return true;
            }


            catch (Exception ex)
            {
                ObjTransaccion.Rollback();
                return false;
            }
            finally
            {
                cn.Close();
            }

        }

        public static int ObtenerUltimoIdTurno()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT MAX(id) FROM turnos";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                int resultado = (int)cmd.ExecuteScalar();
                return resultado;


            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                cn.Close();
            }

        }

        public static DataTable ObtenerProfesionalesXTurnos(string documento)
        {


            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM turnos WHERE numDocProfesional like '" + documento + "'";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }

                else
                {
                    resultado = false;
                }
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

        public static DataTable EstadisticasTurnosXProfesionales(string FechaDesde, string FechaHasta)
        {


            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "select nombreProfesional as Nombre, count(*) as Cantidad from turnos WHERE fechaTurno BETWEEN " + "'" + FechaDesde + "'" + " AND " + "'" + FechaHasta + "'" + " group by nombreProfesional";
                cmd.CommandType = CommandType.Text;
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

        public static DataTable EstadisticasEspecialidades(string FechaDesde, string FechaHasta)
        {


            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "select Especialidad as Especialidad, count(*) as Cantidad FROM turnos WHERE fechaTurno BETWEEN " + "'" + FechaDesde + "'" + " AND " + "'" + FechaHasta + "'" + "group By Especialidad";
                cmd.CommandType = CommandType.Text;
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


        public static DataTable EstadisticasPreciosXProfesionales(string FechaDesde, string FechaHasta)
        {


            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "select nombreProfesional as Nombre, precio as Precio from turnos WHERE fechaTurno BETWEEN " + "'" + FechaDesde + "'" + " AND " + "'" + FechaHasta + "'" + "";
                cmd.CommandType = CommandType.Text;
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


        public static DataTable EstadisticasTurnosXFechas(string FechaDesde, string FechaHasta)
        {


            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "select CAST(fechaturno AS DATE) as Fecha, count(*) as Cantidad from turnos WHERE fechaTurno BETWEEN " + "'" + FechaDesde + "'" + " AND " + "'" + FechaHasta + "'" + "group by fechaTurno";
                cmd.CommandType = CommandType.Text;
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


        public static DataTable ObtenerProfesionales()
        {


            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM turnos";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }

                else
                {
                    resultado = false;
                }
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


        public static DataTable EstadisticasOSSXPrecios(int PrecioDesde, int PrecioHasta)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "select obraSocial as Nombre, precio as Precio from turnos WHERE precio BETWEEN " + "'" + PrecioDesde + "'" + " AND " + "'" + PrecioHasta + "'";
                cmd.CommandType = CommandType.Text;
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
        public static DataTable ObtenerPacientesPorEsp(string Documento, string IDEspecialidad)
        {


            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM turnos WHERE numDocPaciente like " + Documento + "AND Especialidad like "+ IDEspecialidad + "";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }

                else
                {
                    resultado = false;
                }
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

        public static DataTable ObtenerTurnosPorFechas(string FechaDesde, string FechaHasta)
        {


            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                //string consulta = "SELECT * FROM turnos WHERE fechaTurno BETWEEN " + FechaDesde + "AND " + FechaHasta + "";
                
                string consulta = "SELECT * FROM turnos WHERE fechaTurno BETWEEN " + "'" + FechaDesde + "'" + " AND " + "'" + FechaHasta + "'" + "";



                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                //string devuelto "SELECT * FROM turnos WHERE fechaTurno BETWEEN 10/6/2021 15:30:00 AND 16/10/2022 07:10:00"	string



                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                
                if (tabla.Rows.Count >= 1)
                {
                    resultado = true;
                }

                else
                {
                    resultado = false;
                }

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

        public static DataTable ObtenerTurnosPorPrecios(int PrecioDesde, int PrecioHasta)
        {


            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM turnos WHERE precio BETWEEN " + "'" + PrecioDesde + "'" + " AND " + "'" + PrecioHasta + "'" + "";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count >= 1)
                {
                    resultado = true;
                }

                else
                {
                    resultado = false;
                }

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


        public static DataTable ObtenerObrasSociales(int TieneOSS)
        {


            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            if (TieneOSS == 0)
            {
                try
                {
                    bool resultado = false;
                    SqlCommand cmd = new SqlCommand();
                    string consulta = "SELECT * FROM turnos WHERE obraSocial like 0";
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;
                    cn.Open();
                    cmd.Connection = cn;

                    DataTable tabla = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);

                    if (tabla.Rows.Count >= 1)
                    {
                        resultado = true;
                    }

                    else
                    {
                        resultado = false;
                    }

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

            else
            {
                try
                {
                    bool resultado = false;
                    SqlCommand cmd = new SqlCommand();
                    string consulta = "SELECT * FROM turnos WHERE obraSocial <> 0";
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;
                    cn.Open();
                    cmd.Connection = cn;

                    DataTable tabla = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);

                    if (tabla.Rows.Count >= 1)
                    {
                        resultado = true;
                    }

                    else
                    {
                        resultado = false;
                    }

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

        public static DataTable ObtenerPaciente(string letra)
        {


            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM pacientes WHERE apellido like " + letra + "";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
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



        public static DataTable ObtenerProfesionalesContenido(string letra)
        {


            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM profesionales WHERE apellido like " + letra + "";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
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

        public static DataTable ObtenerPacientesContenido(string letra)
        {


            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM pacientes WHERE apellido like " + letra + "";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
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


       


        public static DataTable ObtenerProfesionalesTabla(string letra)
        {


            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM profesionales WHERE apellido like "+letra+"" ;

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
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
