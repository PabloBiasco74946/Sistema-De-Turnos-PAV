using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    public class ObraSocial
    {
        private int IdObraSocial;
        private string RazonSocial;
        private string Nombre;
        private string Telefono;
        private string Email;
        public ObraSocial()
        {

        }
        public ObraSocial(int idObraSocial, string razonSocial, string nombre, string telefono, string email)
        {
            IdObraSocial = idObraSocial;
            RazonSocial = razonSocial;
            Nombre = nombre;
            Telefono = telefono;
            Email = email;

        }

        public int IdDeObraSocial
        {
            get => IdObraSocial;
            set => IdObraSocial = value;
        }

        public string Razon_Social
        {
            get => RazonSocial;
            set => RazonSocial = value;
        }
        public string NombreObraSocial
        {
            get => Nombre;
            set => Nombre = value;
        }

        public string TelefonoObraSocial
        {
            get => Telefono;
            set => Telefono = value;
        }

        public string EmailObraSocial
        {
            get => Email;
            set => Email = value;
        }

    }
}
