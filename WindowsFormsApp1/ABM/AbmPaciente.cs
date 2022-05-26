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
    public partial class AbmPaciente : Form
    {
        public AbmPaciente()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Paciente pac = ObtenerDatosPaciente();
            bool resultado = AdPaciente.AgregarPacienteADB(pac);
            if (resultado)
            {
                MessageBox.Show("Persona agregada con éxito");
                CargarGrilla();
                LimpiarCampos();


            }
            else
            {
                MessageBox.Show("Error al agregar persona.");
            }
        }


        private Paciente ObtenerDatosPaciente()
        {
            Paciente pac = new Paciente();
            pac.NombrePaciente = txtNombrePaciente.Text.Trim();
            pac.ApellidoPaciente = txtApellidoPaciente.Text.Trim();
            pac.TipoDocumentoPaciente = (int)cmbTipoDocPaciente.SelectedValue;
            pac.NumeroDocumentoPaciente = mskNumeroDocumentoPaciente.Text;
            pac.TelefonoPaciente = txtTelefonoPaciente.Text;
            return pac;
        }

        private void AbmPaciente_Load(object sender, EventArgs e)
        {
            CargarComboTiposDocumentos();
            CargarGrilla();
        }

        private void CargarComboTiposDocumentos()
        {

            try
            {
                //cmbTipoDocumento.DataSource = AD_Varios.ObtenerTiposDocumentos();
                cmbTipoDocPaciente.DataSource = AdOtros.ObtenerTabla("tipo_Documento");
                cmbTipoDocPaciente.DisplayMember = "nombre";
                cmbTipoDocPaciente.ValueMember = "cod";
                cmbTipoDocPaciente.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar combo tipo documentos.");

            }
        }

        private void grdPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnEliminar.Enabled = true;
            DataGridViewRow filaseleccionada = grdPaciente.Rows[indice];
            string documento = filaseleccionada.Cells["numerodoc"].Value.ToString();
            Paciente pac = ObtenerPaciente(documento);
            CargarCampos(pac);
            mskNumeroDocumentoPaciente.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnConfirmar.Enabled = false;

        }

        private void CargarGrilla()
        {
            try
            {
                grdPaciente.DataSource = AdPaciente.ObtenerDatosPaciente();

            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener los datos de los profesionales.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            principal ventana = new principal();
            ventana.Show();
        }

        private void CargarCampos(Paciente pac)
        {
            txtNombrePaciente.Text = pac.NombrePaciente;
            txtApellidoPaciente.Text = pac.ApellidoPaciente;
            cmbTipoDocPaciente.SelectedValue = pac.TipoDocumentoPaciente;
            mskNumeroDocumentoPaciente.Text = pac.NumeroDocumentoPaciente;
            txtTelefonoPaciente.Text = pac.TelefonoPaciente;
        }

        private Paciente ObtenerPaciente(string documento)
        {
            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaconexion);
            Paciente pac = new Paciente();
            CargarCampos(pac);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select * from pacientes where nro_doc like @nro_doc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nro_doc", documento);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    pac.NombrePaciente = dr["nombre"].ToString();
                    pac.ApellidoPaciente = dr["apellido"].ToString();
                    pac.NumeroDocumentoPaciente = dr["nro_doc"].ToString();
                    pac.TelefonoPaciente = dr["telefono"].ToString();
                    pac.TipoDocumentoPaciente = int.Parse(dr["tipo_doc"].ToString());
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
            return pac;
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombrePaciente.Text = "";
            txtApellidoPaciente.Text = "";
            txtTelefonoPaciente.Text = "";
            cmbTipoDocPaciente.Text = "";
            mskNumeroDocumentoPaciente.Text = "";
            mskNumeroDocumentoPaciente.Enabled = true;
            btnConfirmar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Paciente pac = ObtenerDatosPaciente();
            bool resultado = ActualizarPaciente(pac);
            if (resultado)
            {
                MessageBox.Show("Paciente actualizado con éxito");
                LimpiarCampos();
                CargarGrilla();
                CargarComboTiposDocumentos();
            }
        }

        private bool ActualizarPaciente(Paciente pac)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE pacientes SET nombre = @nombre, apellido = @apellido, tipo_doc = @tipo_doc, nro_doc = @nro_doc, telefono = @telefono WHERE nro_doc like @nro_doc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", pac.NombrePaciente);
                cmd.Parameters.AddWithValue("@apellido", pac.ApellidoPaciente);
                cmd.Parameters.AddWithValue("@tipo_doc", pac.TipoDocumentoPaciente);
                cmd.Parameters.AddWithValue("@nro_doc", pac.NumeroDocumentoPaciente);
                cmd.Parameters.AddWithValue("@telefono", pac.TelefonoPaciente);
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
            Paciente pac = ObtenerDatosPaciente();
            bool resultado = EliminarPacientes(pac);
            if (resultado)
            {
                MessageBox.Show("¡Paciente eliminado con éxito!");
                LimpiarCampos();
                CargarGrilla();
            }

        }

        private bool EliminarPacientes(Paciente pac)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM pacientes WHERE nro_doc = @nro_doc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", pac.NombrePaciente);
                cmd.Parameters.AddWithValue("@apellido", pac.ApellidoPaciente);
                cmd.Parameters.AddWithValue("@telefono", pac.TelefonoPaciente);
                cmd.Parameters.AddWithValue("@tipo_doc", pac.TipoDocumentoPaciente);
                cmd.Parameters.AddWithValue("@nro_doc", pac.NumeroDocumentoPaciente);
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
