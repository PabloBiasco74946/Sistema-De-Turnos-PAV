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
    public partial class altaProfesional : Form
    {
        public altaProfesional()
        {
            InitializeComponent();
        }


        private void CargarComboTiposDocumentos()
        {

            try
            {

                //cmbTipoDocumento.DataSource = AD_Varios.ObtenerTiposDocumentos();
                cmbTipoDocProfesional.DataSource = AdOtros.ObtenerTabla("tipo_Documento");
                cmbTipoDocProfesional.DisplayMember = "nombre";
                cmbTipoDocProfesional.ValueMember = "cod";
                cmbTipoDocProfesional.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar combo tipo documentos.");

            }
        }

        private void LimpiarCampos()
        {
            txtNombreProfesional.Text = "";
            txtApellidoProfesional.Text = "";
            txtEmailProfesional.Text = "";
            txtMatriculaProfesional.Text = "";
            txtTelefonoProfesional.Text = "";
            mskFechaNacimientoProfesional.Text = "";
            mskNumeroDocumentoProfesional.Text = "";
            cmbTipoDocProfesional.Text = "";
            txtMatriculaProfesional.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnConfirmar.Enabled = true;
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Profesional pro = ObtenerDatosProfesional();

            bool resultado = AdProfesional.AgregarProfesionalADB(pro);
            if (resultado)
            {
                MessageBox.Show("Persona agregada con éxito");
                LimpiarCampos();
                CargarComboTiposDocumentos();
                CargarGrilla();
                txtNombreProfesional.Focus();
            }
            else
            {
                MessageBox.Show("Error al agregar persona.");
            }

        }

        private Profesional ObtenerDatosProfesional()
        {
            Profesional pro = new Profesional();
            pro.NombreProfesional = txtNombreProfesional.Text.Trim();
            pro.ApellidoProfesional = txtApellidoProfesional.Text.Trim();
            pro.FechaNacimientoProfesional = DateTime.Parse(mskFechaNacimientoProfesional.Text);
            pro.TipoDocumentoProfesional = (int)cmbTipoDocProfesional.SelectedValue;
            pro.NumeroDeDocumentoProfesional = mskNumeroDocumentoProfesional.Text;
            pro.EmailProfesional = txtEmailProfesional.Text;
            pro.TelefonoProfesional = txtTelefonoProfesional.Text;
            pro.MatriculaProfesional = txtMatriculaProfesional.Text;
            return pro;
        }

        private void altaProfesional_Load(object sender, EventArgs e)
        {
            txtNombreProfesional.Focus();
            CargarComboTiposDocumentos();
            CargarGrilla();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            principal ventana = new principal();
            ventana.Show();

        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtNombreProfesional.Focus();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnEliminar.Enabled = true;
            DataGridViewRow filaseleccionada = grdProfesional.Rows[indice];
            string documento = filaseleccionada.Cells["numerodoc"].Value.ToString();
            Profesional pro = ObtenerProfesional(documento);
            CargarCampos(pro);
            txtMatriculaProfesional.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnConfirmar.Enabled = false;
        }

        private void CargarCampos(Profesional pro)
        {
            txtNombreProfesional.Text = pro.NombreProfesional;
            txtApellidoProfesional.Text = pro.ApellidoProfesional;
            DateTime fecha = pro.FechaNacimientoProfesional;
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
            mskFechaNacimientoProfesional.Text = dia + mes + año;
            cmbTipoDocProfesional.SelectedValue = pro.TipoDocumentoProfesional;
            mskNumeroDocumentoProfesional.Text = pro.NumeroDeDocumentoProfesional;
            txtMatriculaProfesional.Text = pro.MatriculaProfesional;
            txtEmailProfesional.Text = pro.EmailProfesional;
            txtTelefonoProfesional.Text = pro.TelefonoProfesional;

        }

        private void CargarGrilla()
        {
            try
            {
                grdProfesional.DataSource = AdProfesional.ObtenerDatosProfesional();

            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener los datos de los profesionales.");
            }

        }

        private bool ActualizarProfesional(Profesional pro)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE profesionales SET nombre = @nombre, apellido = @apellido, " +
                    "fecha_Nacimiento = @fecha_Nacimiento, tipoDoc = @tipoDoc, numDoc = @numDoc, " +
                    "matricula_Cirujano = @matricula_Cirujano, email = @email, telefono = @telefono " +
                    "WHERE matricula_Cirujano = @matricula_Cirujano";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", pro.NombreProfesional);
                cmd.Parameters.AddWithValue("@apellido", pro.ApellidoProfesional);
                cmd.Parameters.AddWithValue("@fecha_Nacimiento", pro.FechaNacimientoProfesional);
                cmd.Parameters.AddWithValue("@tipoDoc", pro.TipoDocumentoProfesional);
                cmd.Parameters.AddWithValue("@numDoc", pro.NumeroDeDocumentoProfesional);
                cmd.Parameters.AddWithValue("@matricula_Cirujano", pro.MatriculaProfesional);
                cmd.Parameters.AddWithValue("@email", pro.EmailProfesional);
                cmd.Parameters.AddWithValue("@telefono", pro.TelefonoProfesional);
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
                    pro.MatriculaProfesional = dr["matricula_Cirujano"].ToString();
                    pro.EmailProfesional = dr["email"].ToString();
                    pro.TelefonoProfesional = dr["telefono"].ToString();
                    pro.FechaNacimientoProfesional = DateTime.Parse(dr["fecha_Nacimiento"].ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {
            Profesional pro = ObtenerDatosProfesional();
            bool resultado = AdProfesional.EliminarProfesional(pro);
            if (resultado)
            {
                MessageBox.Show("¡Profesional actualizado con éxito!");
                LimpiarCampos();
                CargarGrilla();
                CargarComboTiposDocumentos();
            }

        }
    

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Profesional pro = ObtenerDatosProfesional();
            bool resultado = ActualizarProfesional(pro);
            if (resultado)
            {
                MessageBox.Show("¡Profesional actualizado con éxito!");
                LimpiarCampos();
                txtNombreProfesional.Focus();
                CargarGrilla();
                CargarComboTiposDocumentos();
            }

        }
        private void GdrProfesional_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnEliminar.Enabled = true;
            DataGridViewRow filaseleccionada = grdProfesional.Rows[indice];
            string documento = filaseleccionada.Cells["numerodoc"].Value.ToString();
            Profesional pro = ObtenerProfesional(documento);
            CargarCampos(pro);
        }

        private void lblAltaProfesional_Click(object sender, EventArgs e)
        {

        }

        private void mskNumeroDocumentoProfesional_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtMatriculaProfesional_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMatricula_Click(object sender, EventArgs e)
        {

        }

        private void mskFechaNacimientoProfesional_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cmbTipoDocProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefonoProfesional_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailProfesional_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoProfesional_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreProfesional_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblNroDocumento_Click(object sender, EventArgs e)
        {

        }

        private void lblTipoDoc_Click(object sender, EventArgs e)
        {

        }
    }
}
