using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.AccesoADatos;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.ABM
{
    public partial class AbmArancel : Form
    {
        public AbmArancel()
        {
            InitializeComponent();
        }

        public static bool ValidarArancel(string DniProfesional)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM aranceles WHERE numDocProfesional like @numDocProfesional";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@numDocProfesional", DniProfesional);
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

                return resultado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }

        private Arancel ObtenerDatosArancel()
        {
            Arancel ara = new Arancel();
            ara.NumDocDeProfesional = mskNumeroDocumentoProfesional.Text.Trim();
            ara.FechaDeInicioVigencia = DateTime.Parse(mskFechaInicio.Text);
            ara.FechaDeFinVigencia = DateTime.Parse(mskFechaInicio.Text);
            ara.PrecioDeArancel = txtPrecio.Text.Trim();
            ara.TipoDocDeProfesional = int.Parse(txtTipoDocAux.Text.Trim());
            return ara;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string DniProfesional = mskNumeroDocumentoProfesional.Text;
            string ArancelProfesional = txtPrecio.Text;

            try
            {
                bool resultado = ValidarArancel(DniProfesional);
                if (resultado == false)
                {
                    Arancel ara = ObtenerDatosArancel();

                    bool resultado2 = AdArancel.AgregarArancelADB(ara);
                    if (resultado2)
                    {
                        MessageBox.Show("Arancel agregado con éxito");
                        LimpiarCampos();
                        CargarGrilla();
                        mskNumeroDocumentoProfesional.Focus();
                        CargarGrillaArancel();
                    }

                    else
                    {
                        MessageBox.Show("¡No se pudo dar de alta el arancel!");
                    }


                }

                else
                {
                    MessageBox.Show("¡El profesional con este DNI ya tiene un contrato con arancel existente!");
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("No se pueden leer los datos del arancel");
            }

        }

               
            
            

        


       
        

        private void CargarGrilla()
        {
            try
            {
                grdProfesional.DataSource = AdProfesional.ObtenerDatosProfesional();

            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener los datos de los Profesionales.");
            }

        }

        private void CargarGrillaArancel()
        {
            try
            {
                grdArancel.DataSource = AdArancel.ObtenerDatosArancel();

            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener los datos de los Aranceles.");
            }

        }

        private void LimpiarCampos()
        {
            mskNumeroDocumentoProfesional.Text = "";
            mskFechaInicio.Text = "";
            mskFechaFin.Text = "";
            txtID.Text = "";
            txtPrecio.Text = "";
            txtTipoDocumentoPro.Text = "";
        }


        




        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal ventana = new principal();
            ventana.Show();
        }

        private void AbmArancel_Load(object sender, EventArgs e)
        {
            txtPrecio.Text = "0";
            LimpiarCampos();
            CargarGrilla();
            CargarGrillaArancel();

        }

        private void cmbTipoDocProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grdProfesional_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnEliminar.Enabled = true;
            DataGridViewRow filaseleccionada = grdProfesional.Rows[indice];
            string documento = filaseleccionada.Cells["numdoc"].Value.ToString();
            Profesional pro = ObtenerProfesional(documento);
            CargarCampos(pro);
            mskFechaFin.Enabled = true;
            mskFechaInicio.Enabled = true;
            txtPrecio.Enabled = true;
            btnConfirmar.Enabled = true;
        }

        private Profesional ObtenerProfesional(string documento)
        {
            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaconexion);
            Profesional pro = new Profesional();
            CargarCampos(pro);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select * from profesionales where numDoc like @numDoc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@numDoc", documento);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    pro.NombreProfesional = dr["nombre"].ToString();
                    pro.ApellidoProfesional = dr["apellido"].ToString();
                    pro.NumeroDeDocumentoProfesional = dr["numDoc"].ToString();
                    pro.TipoDocumentoProfesional = int.Parse(dr["tipoDoc"].ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return pro;
        }

        private void CargarCampos(Profesional pro)
        {
            LimpiarCampos();
            txtNombrePro.Text = pro.NombreProfesional;
            txtApellidopro.Text = pro.ApellidoProfesional;
            txtTipoDocAux.Text = pro.TipoDocumentoProfesional.ToString();
            mskNumeroDocumentoProfesional.Text = pro.NumeroDeDocumentoProfesional;
            string valorTipoDoc = pro.TipoDocumentoProfesional.ToString();
            if (valorTipoDoc.Equals("1"))
            {
                txtTipoDocumentoPro.Text = "DNI";
            }

            else if (valorTipoDoc.Equals("2"))
            {
                txtTipoDocumentoPro.Text = "Libreta Universitaria";
            }

            else if(valorTipoDoc.Equals("3")) 
            {
                txtTipoDocumentoPro.Text = "Pasaporte";
            }


        }

        private void grdArancel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaseleccionada = grdArancel.Rows[indice];
            string idara = filaseleccionada.Cells["idarancel"].Value.ToString();
            Arancel ara = ObtenerAranceles(idara);
            CargarCamposArancel(ara);
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            mskFechaFin.Enabled = true;
            mskFechaInicio.Enabled = true;
            txtPrecio.Enabled = true;
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private Arancel ObtenerAranceles(string idara)
        {
            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaconexion);
            Arancel ara = new Arancel();
            CargarCamposArancel(ara);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select * from aranceles WHERE idArancel = @idArancel";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idArancel", idara);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    ara.TipoDocDeProfesional = int.Parse(dr["tipoDocProfesional"].ToString());
                    ara.NumDocDeProfesional = dr["numDocProfesional"].ToString();
                    ara.FechaDeInicioVigencia = DateTime.Parse(dr["fecha_Inicio_Vigencia"].ToString());
                    ara.FechaDeFinVigencia = DateTime.Parse(dr["fecha_Fin_Vigencia"].ToString());
                    ara.PrecioDeArancel = dr["Precio"].ToString();
                    ara.IdDeAranceles = int.Parse(dr["idArancel"].ToString());

                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return ara;
        }

        private void CargarCamposArancel(Arancel ara)
        {
            LimpiarCampos();
            DateTime fecha = ara.FechaDeInicioVigencia;
            string dia = "";
            string mes = "";
            string año = "";
            dia = fecha.Date.Day.ToString();
            if (dia.Length == 1)
            {
                dia = "0" + dia;
            }

            mes = fecha.Date.Month.ToString();
            if (mes.Length == 1)
            {
                mes = "0" + mes;
            }

            año = fecha.Date.Year.ToString();

            DateTime fecha2 = ara.FechaDeFinVigencia;
            string dia2 = "";
            string mes2 = "";
            string año2 = "";
            dia2 = fecha2.Date.Day.ToString();
            if (dia2.Length == 1)
            {
                dia2 = "0" + dia2;
            }

            mes2 = fecha2.Date.Month.ToString();
            if (mes2.Length == 1)
            {
                mes2 = "0" + mes2;
            }

            año2 = fecha2.Date.Year.ToString();

            mskFechaInicio.Text = dia + mes + año;
            mskFechaFin.Text = dia2 + mes2 + año2;
            txtTipoDocAux.Text = ara.TipoDocDeProfesional.ToString();
            mskNumeroDocumentoProfesional.Text = ara.NumDocDeProfesional;
            txtPrecio.Text = ara.PrecioDeArancel;
            string valorTipoDoc = ara.TipoDocDeProfesional.ToString();
            if (valorTipoDoc.Equals("1"))
            {
                txtTipoDocumentoPro.Text = "DNI";
            }

            else if (valorTipoDoc.Equals("2"))
            {
                txtTipoDocumentoPro.Text = "Libreta Universitaria";
            }

            else if (valorTipoDoc.Equals("3"))
            {
                txtTipoDocumentoPro.Text = "Pasaporte";
            }
            txtID.Text = ara.IdDeAranceles.ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
                Arancel ara = ObtenerIdArancel();
                bool resultado = EliminarArancel(ara);
                if (resultado)
                {
                    MessageBox.Show("¡Arancel eliminado con éxito!");
                    LimpiarCampos();
                    CargarGrillaArancel();
                }
        }

        private Arancel ObtenerIdArancel()
        {
            Arancel ara = new Arancel();

            ara.NumDocDeProfesional = mskNumeroDocumentoProfesional.Text.Trim();
            ara.TipoDocDeProfesional = int.Parse(txtTipoDocAux.Text);
            ara.IdDeAranceles = int.Parse(txtID.Text);
            ara.FechaDeInicioVigencia = DateTime.Parse(mskFechaInicio.Text);
            ara.FechaDeFinVigencia = DateTime.Parse(mskFechaFin.Text);
            ara.PrecioDeArancel = txtPrecio.Text;

            return ara;
        }

        private bool EliminarArancel(Arancel ara)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM aranceles WHERE idArancel = @idArancel";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDocProfesional", ara.TipoDocDeProfesional);
                cmd.Parameters.AddWithValue("@numDocProfesional", ara.NumDocDeProfesional);
                cmd.Parameters.AddWithValue("@fecha_Inicio_Vigencia", ara.FechaDeInicioVigencia);
                cmd.Parameters.AddWithValue("@fecha_Fin_Vigencia", ara.FechaDeFinVigencia);
                cmd.Parameters.AddWithValue("@precio", ara.PrecioDeArancel);
                cmd.Parameters.AddWithValue("@idArancel", ara.IdDeAranceles);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Arancel ara = ObtenerIdArancel();
            bool resultado = ActualizarArancel(ara);
            if (resultado)
            {
                MessageBox.Show("Arancel actualizado con éxito");
                LimpiarCampos();
                CargarGrilla();
                CargarGrillaArancel();

            }
        }

        private bool ActualizarArancel(Arancel ara)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE aranceles SET tipoDocProfesional = @tipoDocProfesional, numDocProfesional = @numDocProfesional," +
                    "fecha_Inicio_Vigencia = @fecha_Inicio_Vigencia, fecha_Fin_Vigencia = @fecha_Fin_Vigencia, precio = @precio" +
                    " WHERE idArancel like @idArancel";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDocProfesional", ara.TipoDocDeProfesional);
                cmd.Parameters.AddWithValue("@numDocProfesional", ara.NumDocDeProfesional);
                cmd.Parameters.AddWithValue("@fecha_Inicio_Vigencia", ara.FechaDeInicioVigencia);
                cmd.Parameters.AddWithValue("@fecha_Fin_Vigencia", ara.FechaDeFinVigencia);
                cmd.Parameters.AddWithValue("@precio", ara.PrecioDeArancel);
                cmd.Parameters.AddWithValue("@idArancel", ara.IdDeAranceles);
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

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
