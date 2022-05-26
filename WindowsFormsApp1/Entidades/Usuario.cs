using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    public class Usuario
    {
        private string NombreUsuario;
        private string ContraseñaUsuario;
        private int IdUsuario;


        public Usuario()
        {

        }
        public Usuario(string nombreUsuario, string contraseñaUsuario, int idUsuario)
        {
            NombreUsuario = nombreUsuario;
            ContraseñaUsuario = contraseñaUsuario;
            IdUsuario = idUsuario;
        }

        public string NombreDeUsuario
        {
            get => NombreUsuario;
            set => NombreUsuario = value;
        }

        public string ContraseñaDeUsuario
        {
            get => ContraseñaUsuario;
            set => ContraseñaUsuario = value;
        }
        public int IdDeUsuario
        {
            get => IdUsuario;
            set => IdUsuario = value;
        }
    }
}
