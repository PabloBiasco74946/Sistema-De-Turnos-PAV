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
    public partial class AbmEspecialidad : Form
    {
        public AbmEspecialidad()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Especialidad esp = ObtenerDatosEspecialidad();

            bool resultado = AdEspecialidad.AgregarEspecialidadADB(esp);
            if (resultado)
            {
                MessageBox.Show("Especialidad agregada con éxito");
                LimpiarCampos();
                CargarGrilla();
                txtNombreEspecialidad.Focus();
            }
            else
            {
                MessageBox.Show("Error al agregar la Especialidad.");
            }
        }

        private Especialidad ObtenerDatosEspecialidad()
        {
            Especialidad esp = new Especialidad();

            esp.NombreDeEspecialidad = txtNombreEspecialidad.Text.Trim();
            esp.DescripcionEspecialidad = txtDescripcion.Text.Trim();
            esp.IdDeEspecialidades = int.Parse(txtIdEspecialidad.Text.Trim());

            return esp;
        }

        private Especialidad ObtenerIdEspecialidad()
        {
            Especialidad esp = new Especialidad();

            esp.NombreDeEspecialidad = txtNombreEspecialidad.Text.Trim();
            esp.DescripcionEspecialidad = txtDescripcion.Text.Trim();
            esp.IdDeEspecialidades = int.Parse(txtIdEspecialidad.Text);

            return esp;
        }

        private void CargarGrilla()
        {
            try
            {
                grdEspecialidad.DataSource = AdEspecialidad.ObtenerDatosEspecialidad();

            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener los datos de la especialidad.");
            }

        }
        private void LimpiarCampos()
        {
            txtDescripcion.Text = "";
            txtNombreEspecialidad.Text = "";
            ObtenerUltimoIdEspecialidad();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnConfirmar.Enabled = true;

        }

        private void AbmEspecialidad_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            LimpiarCampos();
            ObtenerUltimoIdEspecialidad();
        }

        private void ObtenerUltimoIdEspecialidad()
        {

            int id = AdEspecialidad.ObtenerUltimoIdEspecialidad();
            txtIdEspecialidad.Text = (id + 1).ToString();
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Especialidad esp = ObtenerIdEspecialidad();
            bool resultado = ActualizarEspecialidad(esp);
            if (resultado)
            {
                MessageBox.Show("Especialidad actualizada con éxito");
                LimpiarCampos();
                CargarGrilla();
            }
        }
        private bool ActualizarEspecialidad(Especialidad esp)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE especialidades SET Nombre = @Nombre, Descripcion = @Descripcion WHERE Id_Especialidades like @Id_Especialidades";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", esp.NombreDeEspecialidad);
                cmd.Parameters.AddWithValue("@Descripcion", esp.DescripcionEspecialidad);
                cmd.Parameters.AddWithValue("@Id_Especialidades", esp.IdDeEspecialidades);
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

        private void grdEspecialidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaseleccionada = grdEspecialidad.Rows[indice];
            string id = filaseleccionada.Cells["idEspecialidades"].Value.ToString();
            Especialidad esp = ObtenerEspecialidad(id);
            CargarCampos(esp);
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnConfirmar.Enabled = false;
        }


        private Especialidad ObtenerEspecialidad(string idesp)
        {
            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaconexion);
            Especialidad esp = new Especialidad();
            CargarCampos(esp);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select * from especialidades WHERE Id_Especialidades = @Id_Especialidades";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id_Especialidades", idesp);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    esp.NombreDeEspecialidad = dr["Nombre"].ToString();
                    esp.DescripcionEspecialidad = dr["Descripcion"].ToString();
                    esp.IdDeEspecialidades = int.Parse(dr["Id_Especialidades"].ToString());

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
            return esp;
        }

        private void CargarCampos(Especialidad esp)
        {
            txtNombreEspecialidad.Text = esp.NombreDeEspecialidad;
            txtDescripcion.Text = esp.DescripcionEspecialidad;
            txtIdEspecialidad.Text = esp.IdDeEspecialidades.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Especialidad esp = ObtenerIdEspecialidad();
            bool resultado = EliminarEspecialidad(esp);
            if (resultado)
            {
                MessageBox.Show("¡Especialidad eliminada con éxito!");
                LimpiarCampos();
                CargarGrilla();
            }


        }

        private bool EliminarEspecialidad(Especialidad esp)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM especialidades WHERE Id_Especialidades = @Id_Especialidades";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", esp.NombreDeEspecialidad);
                cmd.Parameters.AddWithValue("@Descripcion", esp.DescripcionEspecialidad);
                cmd.Parameters.AddWithValue("@Id_Especialidades", esp.IdDeEspecialidades);
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