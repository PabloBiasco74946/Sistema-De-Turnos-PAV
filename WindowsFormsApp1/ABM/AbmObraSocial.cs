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
    public partial class AbmObraSocial : Form
    {
        public AbmObraSocial()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ObraSocial obs = ObtenerDatosObraSocial();

            bool resultado = AdObraSocial.AgregarObraSocialADB(obs);
            if (resultado)
            {
                MessageBox.Show("Obra Social agregada con éxito");
                LimpiarCampos();
                CargarGrilla();
                txtNombreObraSocial.Focus();
            }
            else
            {
                MessageBox.Show("Error al agregar la Obra Social.");
            }
        }

        private ObraSocial ObtenerDatosObraSocial()
        {
            ObraSocial obs = new ObraSocial();
            
            obs.NombreObraSocial = txtNombreObraSocial.Text.Trim();
            obs.Razon_Social = txtRazonSocial.Text.Trim();
            obs.EmailObraSocial = txtEmailObraSocial.Text.Trim();
            obs.TelefonoObraSocial = txtTelefonoObraSocial.Text.Trim();

            return obs;
        }

        private void CargarGrilla()
        {
            try
            {
                grdObraSocial.DataSource = AdObraSocial.ObtenerDatosObraSocial();

            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener los datos de los profesionales.");
            }

        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtRazonSocial.Text = "";
            txtNombreObraSocial.Text = "";
            txtTelefonoObraSocial.Text = "";
            txtEmailObraSocial.Text = "";
            txtIdObraSocial.Text = "";
            btnConfirmar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void AbmObraSocial_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void grdObraSocial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaseleccionada = grdObraSocial.Rows[indice];
            string id = filaseleccionada.Cells["Id_ObraSocial"].Value.ToString();
            ObraSocial obs = ObtenerObraSocial(id);
            CargarCampos(obs);
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnConfirmar.Enabled = false;
            
        }

        private ObraSocial ObtenerIdObraSocial()
        {
            ObraSocial obs = new ObraSocial();

            obs.NombreObraSocial = txtNombreObraSocial.Text.Trim();
            obs.Razon_Social = txtRazonSocial.Text.Trim();
            obs.EmailObraSocial = txtEmailObraSocial.Text.Trim();
            obs.TelefonoObraSocial = txtTelefonoObraSocial.Text.Trim();
            obs.IdDeObraSocial = int.Parse(txtIdObraSocial.Text);

            return obs;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ObraSocial obs = ObtenerIdObraSocial();
            bool resultado = ActualizarObraSocial(obs);
            if (resultado)
            {
                MessageBox.Show("Obra Social actualizada con éxito");
                LimpiarCampos();
                CargarGrilla();
                
            }
        }

        private void CargarCampos(ObraSocial obs)
        {
            txtNombreObraSocial.Text = obs.NombreObraSocial;
            txtRazonSocial.Text = obs.Razon_Social;
            txtEmailObraSocial.Text = obs.EmailObraSocial;
            txtTelefonoObraSocial.Text = obs.TelefonoObraSocial;
            txtIdObraSocial.Text = obs.IdDeObraSocial.ToString();
        }


        private bool ActualizarObraSocial(ObraSocial obs)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE obrasSociales SET nombre = @nombre, razonSocial = @razonSocial, email = @email," +
                    "telefono = @telefono WHERE id_ObraSocial like @id_ObraSocial";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", obs.NombreObraSocial);
                cmd.Parameters.AddWithValue("@razonSocial", obs.Razon_Social);
                cmd.Parameters.AddWithValue("@email", obs.EmailObraSocial);
                cmd.Parameters.AddWithValue("@telefono", obs.TelefonoObraSocial);
                cmd.Parameters.AddWithValue("@id_ObraSocial", obs.IdDeObraSocial);
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

        private ObraSocial ObtenerObraSocial(string idobs)
        {
            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaconexion);
            ObraSocial obs = new ObraSocial();
            CargarCampos(obs);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select * from obrasSociales WHERE id_ObraSocial like @id_ObraSocial";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_ObraSocial", idobs);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    obs.NombreObraSocial = dr["nombre"].ToString();
                    obs.Razon_Social = dr["razonSocial"].ToString();
                    obs.IdDeObraSocial = int.Parse(dr["id_ObraSocial"].ToString());
                    obs.TelefonoObraSocial = dr["telefono"].ToString();
                    obs.EmailObraSocial = dr["email"].ToString();
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
            return obs;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ObraSocial obs= ObtenerIdObraSocial();
            bool resultado = EliminarObraSocial(obs);
            if (resultado)
            {
                MessageBox.Show("¡Obra Social eliminada con éxito!");
                LimpiarCampos();
                CargarGrilla();

            }
        }


        private bool EliminarObraSocial(ObraSocial obs)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM obrasSociales WHERE id_ObraSocial = @id_ObraSocial";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", obs.NombreObraSocial);
                cmd.Parameters.AddWithValue("@razonSocial", obs.Razon_Social);
                cmd.Parameters.AddWithValue("@telefono", obs.TelefonoObraSocial);
                cmd.Parameters.AddWithValue("@email", obs.EmailObraSocial);
                cmd.Parameters.AddWithValue("@id_ObraSocial", obs.IdDeObraSocial);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal ventana = new principal();
            ventana.Show();
        }
    }
}
