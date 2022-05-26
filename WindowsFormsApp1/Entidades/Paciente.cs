using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    class Paciente
    {
        private string Nombre;
        private string Apellido;
        private int IdTipoDocumento;
        private string NumeroDeDocumento;
        private string Telefono;


        public Paciente(string nombre, string apellido, int idtipoDocumento, string numeroDeDocumento, string telefono)
        {

            Nombre = nombre;
            Apellido = apellido;
            IdTipoDocumento = idtipoDocumento;
            NumeroDeDocumento = numeroDeDocumento;
            Telefono = telefono;
        }


        public Paciente()
        {

        }

        public string NombrePaciente
        {
            get => Nombre;
            set => Nombre = value;
        }


        public string ApellidoPaciente
        {
            get => Apellido;
            set => Apellido = value;
        }

        public int TipoDocumentoPaciente
        {
            get => IdTipoDocumento;
            set => IdTipoDocumento = value;
        }

        public string NumeroDocumentoPaciente
        {
            get => NumeroDeDocumento;
            set => NumeroDeDocumento = value;
        }


        public string TelefonoPaciente
        {
            get => Telefono;
            set => Telefono = value;
        }


    }
}
