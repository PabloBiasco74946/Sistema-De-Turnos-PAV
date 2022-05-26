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
    public partial class modificarUsuario : Form
    {
        public modificarUsuario()
        {
            InitializeComponent();
        }

        private Usuario ObtenerUsuario(string documento)
        {
            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaconexion);
            Usuario usu = new Usuario();
            CargarCampos(usu);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select * from usuariosSistema WHERE idUsuario like @idUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idUsuario", documento);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    usu.NombreDeUsuario = dr["usuario"].ToString();
                    usu.ContraseñaDeUsuario = dr["contraseña"].ToString();
                    usu.IdDeUsuario = int.Parse(dr["idUsuario"].ToString());
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
            return usu;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaseleccionada = grdModificarUsu.Rows[indice];
            string documento = filaseleccionada.Cells["idusuario"].Value.ToString();
            Usuario usu = ObtenerUsuario(documento);
            CargarCampos(usu);
            btnModificar.Enabled = true;
        }

        private Usuario ObtenerDatosUsuarios()
        {
            Usuario usu = new Usuario();
            usu.NombreDeUsuario = txtNombreUsuario.Text.Trim();
            usu.ContraseñaDeUsuario = txtContraseña1.Text.Trim();
            usu.IdDeUsuario = int.Parse(txtIdUsu.Text);
          
            return usu;
        }

        private void LimpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtContraseña1.Text = "";
            txtContraseña2.Text = "";
            txtIdUsu.Text = "";
        }

        private void CargarCampos(Usuario usu)
        {
            txtNombreUsuario.Text = usu.NombreDeUsuario;
            txtContraseña1.Text = usu.ContraseñaDeUsuario;
            txtContraseña2.Text = usu.ContraseñaDeUsuario;
            txtIdUsu.Text = usu.IdDeUsuario.ToString();

        }

        private void modificarUsuario_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                grdModificarUsu.DataSource = AdUsuarios.ObtenerDatosUsuario();

            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener los datos de los profesionales.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usu = ObtenerDatosUsuarios();
            bool resultado = ActualizarUsuarios(usu);
            if (resultado)
            {
                MessageBox.Show("¡Usuario actualizado con éxito!");
                LimpiarCampos();
                CargarGrilla();
            }
        }
        private bool ActualizarUsuarios(Usuario usu)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE usuariosSistema SET usuario = @usuario, contraseña = @contraseña WHERE idUsuario = @idUsuario"; 
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usuario", usu.NombreDeUsuario);
                cmd.Parameters.AddWithValue("@contraseña", usu.ContraseñaDeUsuario);
                cmd.Parameters.AddWithValue("@idUsuario", usu.IdDeUsuario);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTituloModificarUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtIdUsu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
