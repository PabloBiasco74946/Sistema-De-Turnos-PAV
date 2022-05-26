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
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.ABM
{
    public partial class altaUsuario : Form
    {
        public altaUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usu = ObtenerDatosUsuarios();
            if (txtContraseña.Text == txtContraseña2.Text) 
            {
               if (txtNombreUsuario.Text != "" && txtContraseña.Text != "")
               {
                    bool resultado = AccesoADatos.AdUsuarios.AgregarUsuarioADB(usu);
                    MessageBox.Show("¡Usuario registrado exitosamente!");
                    this.Close();
               }

               else
                {
                    MessageBox.Show("¡Los campos están vacíos, ingresalos correctamente!");
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas proporcionadas no coinciden!");
                LimpiarCampos();
            }           
        }

        private Usuario ObtenerDatosUsuarios()
        {
            Usuario usu = new Usuario();
            usu.NombreDeUsuario = txtNombreUsuario.Text.Trim();
            usu.ContraseñaDeUsuario = txtContraseña.Text.Trim();
            return usu;
        }


        private void LimpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtContraseña.Text = "";
            txtContraseña2.Text = "";
        }

        private void altaUsuario_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }


    }
}
