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
    public partial class AbmClinica : Form
    {
        public AbmClinica()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Clinica cli = ObtenerDatosClinica();

            bool resultado = AdClinica.AgregarClinicaADB(cli);
            if (resultado)
            {
                MessageBox.Show("Clinica agregada con éxito");
                LimpiarCampos();
                CargarGrilla();
                CargarComboBarrios();
            }
        }

        private void CargarComboBarrios()
        {

            try
            {

                //cmbTipoDocumento.DataSource = AD_Varios.ObtenerTiposDocumentos();
                cmbBarrio.DataSource = AdOtros.ObtenerTabla("barrios");
                cmbBarrio.DisplayMember = "nombre";
                cmbBarrio.ValueMember = "id_Barrio";
                cmbBarrio.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar barrios.");

            }
        }

        private void LimpiarCampos()
        {
            txtCalle.Text = "";
            cmbBarrio.Text = "";
            txtIdClinica.Text = "";
            txtNombreClinica.Text = "";
            txtRazonSocial.Text = "";
            mskNumeroCalle.Text = "";
        }

        private void CargarGrilla()
        {
            try
            {
                grdClinica.DataSource = AdClinica.ObtenerDatosClinica();

            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener los datos de la especialidad.");
            }

        }

        private Clinica ObtenerDatosClinica()
        {
            Clinica cli = new Clinica();

            cli.NombreDeClinica = txtNombreClinica.Text.Trim();
            cli.RazonDeClinica = txtRazonSocial.Text.Trim();
            cli.CalleClinica = txtCalle.Text.Trim();
            cli.NumeroDeClinica = mskNumeroCalle.Text.Trim();
            cli.IdDeBarrio = (int)cmbBarrio.SelectedValue;

            return cli;
        }

        private Clinica ObtenerIdDatosClinica()
        {
            Clinica cli = new Clinica();

            cli.NombreDeClinica = txtNombreClinica.Text;
            cli.RazonDeClinica = txtRazonSocial.Text;
            cli.CalleClinica = txtCalle.Text;
            cli.NumeroDeClinica = mskNumeroCalle.Text;
            cli.IdDeBarrio = (int)cmbBarrio.SelectedValue;
            cli.IdDeClinica = int.Parse(txtIdClinica.Text);

            return cli;
        }

        private void AbmClinica_Load(object sender, EventArgs e)
        {
            CargarComboBarrios();
            CargarGrilla();
        }

        private void grdClinica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnEliminar.Enabled = true;
            DataGridViewRow filaseleccionada = grdClinica.Rows[indice];
            string idclinica = filaseleccionada.Cells["idClinica"].Value.ToString();
            Clinica cli = ObtenerClinica(idclinica);
            CargarCampos(cli);
            btnModificar.Enabled = true;
            btnConfirmar.Enabled = false;
        }

        private void CargarCampos(Clinica cli)
        {
            txtNombreClinica.Text = cli.NombreDeClinica;
            txtRazonSocial.Text = cli.RazonDeClinica;       
            cmbBarrio.SelectedValue = cli.IdDeBarrio;
            mskNumeroCalle.Text = cli.NumeroDeClinica;
            txtCalle.Text = cli.CalleClinica;
            txtIdClinica.Text = cli.IdDeClinica.ToString();
        }

        private Clinica ObtenerClinica(string idclinica)
        {
            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaconexion);
            Clinica cli = new Clinica();
            CargarCampos(cli);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select * from clinicas where id_Clinica like @id_Clinica";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_Clinica", idclinica);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    cli.NombreDeClinica = dr["nombre"].ToString();
                    cli.RazonDeClinica = dr["razonSocial"].ToString();
                    cli.NumeroDeClinica = dr["numero"].ToString();
                    cli.CalleClinica = dr["calle"].ToString();
                    cli.IdDeBarrio = int.Parse(dr["id_Barrio"].ToString());
                    cli.IdDeClinica = int.Parse(dr["id_Clinica"].ToString());
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
            return cli;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal ventana = new principal();
            ventana.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clinica cli = ObtenerIdDatosClinica();
            bool resultado = ActualizarClinica(cli);
            if (resultado)
            {
                MessageBox.Show("¡Clinica actualizada con éxito!");
                LimpiarCampos();
                txtNombreClinica.Focus();
                CargarGrilla();
                btnEliminar.Enabled = false;
                CargarComboBarrios();
            }

        }

        private bool ActualizarClinica(Clinica cli)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE clinicas SET nombre = @nombre, razonSocial =" +
                    " @razonSocial, calle = @calle, numero = @numero, " +
                    "id_Barrio = id_Barrio WHERE id_Clinica = @id_Clinica";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", cli.NombreDeClinica);
                cmd.Parameters.AddWithValue("@razonSocial", cli.RazonDeClinica);
                cmd.Parameters.AddWithValue("@calle", cli.CalleClinica);
                cmd.Parameters.AddWithValue("@id_Barrio", cli.IdDeBarrio);
                cmd.Parameters.AddWithValue("@numero", cli.NumeroDeClinica);
                cmd.Parameters.AddWithValue("@id_Clinica", cli.IdDeClinica);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clinica cli = ObtenerIdDatosClinica();
            bool resultado = EliminarClinica(cli);
            if (resultado)
            {
                MessageBox.Show("¡Arancel eliminado con éxito!");
                LimpiarCampos();
                CargarGrilla();
            }
        }

        private bool EliminarClinica(Clinica cli)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM clinicas WHERE id_Clinica = @id_Clinica";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", cli.NombreDeClinica);
                cmd.Parameters.AddWithValue("@razonSocial", cli.RazonDeClinica);
                cmd.Parameters.AddWithValue("@calle", cli.CalleClinica);
                cmd.Parameters.AddWithValue("@numero", cli.NumeroDeClinica);
                cmd.Parameters.AddWithValue("@id_Clinica", cli.IdDeClinica);
                cmd.Parameters.AddWithValue("@id_Barrio", cli.IdDeBarrio);
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

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtNombreClinica.Focus();
        }
    }
}
