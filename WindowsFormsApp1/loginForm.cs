using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.AccesoADatos;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuarioLogin.Text.Equals("") && txtContraseñaLogin.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese nombre de usuario y contraseña!");
            }
            else
            {
                string nombreDeUsuario = txtUsuarioLogin.Text;
                string password = txtContraseñaLogin.Text;
                int idUsuario = 3;
                bool resultado = false;

                try
                {
                    resultado = AdUsuarios.ValidarUsuario(nombreDeUsuario, password, idUsuario);
                    if (resultado == true)
                    {
                        Usuario usu = new Usuario(nombreDeUsuario, password, idUsuario);
                        principal ventana = new principal();
                        ventana.Show();
                        this.Hide();

                    }

                    else
                    {
                        MessageBox.Show("¡Usuario inexistente!");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se pueden leer los datos de usuario");
                }

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
