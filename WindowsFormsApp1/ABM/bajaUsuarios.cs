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
    public partial class bajaUsuarios : Form
    {
        public bajaUsuarios()
        {
            InitializeComponent();
        }

        private void bajaUsuarios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario usu = ObtenerDatosUsuarios();
            bool resultado = EliminarUsuarios(usu);
            if (resultado)
            {
                MessageBox.Show("¡Usuario eliminado con éxito!");
                LimpiarCampos();
                CargarGrilla();

            }
        }

     
        private Usuario ObtenerUsuarios(string idusu)
        {
            string cadenaconexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaconexion);
            Usuario usu = new Usuario();

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "select * from usuariosSistema WHERE idUsuario like @idUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idUsuario", idusu);


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

        private void CargarGrilla()
        {
            try
            {
                grdEliminarUsu.DataSource = AdUsuarios.ObtenerDatosUsuario();

            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener los datos de los profesionales.");
            }

        }

        private void grdEliminarUsu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaseleccionada = grdEliminarUsu.Rows[indice];
            string idusu = filaseleccionada.Cells["idusuario"].Value.ToString();
            Usuario usu = ObtenerUsuarios(idusu);
            CargarCampos(usu);
            MessageBox.Show("Usuario seleccionado: "+ txtNombreUsuario.Text + " - ID: "+ txtIdUsu.Text);
        }

        private void LimpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtContraseña.Text = "";
            txtIdUsu.Text = "";
        }


        private Usuario ObtenerDatosUsuarios()
        {
            Usuario usu = new Usuario();
            usu.NombreDeUsuario = txtNombreUsuario.Text.Trim();
            usu.ContraseñaDeUsuario = txtContraseña.Text.Trim();
            usu.IdDeUsuario = int.Parse(txtIdUsu.Text);

            return usu;
        }

        private bool EliminarUsuarios(Usuario usu)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM usuariosSistema WHERE idUsuario = @idUsuario";
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

        private void CargarCampos(Usuario usu)
        {
            txtNombreUsuario.Text = usu.NombreDeUsuario;
            txtContraseña.Text = usu.ContraseñaDeUsuario;
            txtIdUsu.Text = usu.IdDeUsuario.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
