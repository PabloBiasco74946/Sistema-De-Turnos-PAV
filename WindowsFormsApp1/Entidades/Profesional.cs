using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1.Entidades
{
    class Profesional
    {
        private string Nombre;
        private string Apellido;
        private int IdTipoDocumento;
        private DateTime FechaNacimiento;
        private string NumeroDeDocumento;
        private string Email;
        private string Telefono;
        private string Matricula;
        


        public Profesional(string nombre, string apellido, int idtipoDocumento, DateTime fechaNacimiento, string numeroDeDocumento, string email, string telefono, string matricula)
        {

            Nombre = nombre;
            Apellido = apellido;
            IdTipoDocumento = idtipoDocumento;
            FechaNacimiento = fechaNacimiento;
            NumeroDeDocumento = numeroDeDocumento;
            Email = email;
            Telefono = telefono;
            Matricula = matricula;

        }


        public Profesional()
        {

        }

        public string NombreProfesional
        {
            get => Nombre;
            set => Nombre = value;
        }


        public string ApellidoProfesional
        {
            get => Apellido;
            set => Apellido = value;
        }

        public int TipoDocumentoProfesional
        {
            get => IdTipoDocumento;
            set => IdTipoDocumento = value;
        }

        public string NumeroDeDocumentoProfesional
        {
            get => NumeroDeDocumento;
            set => NumeroDeDocumento = value;
        }

        public DateTime FechaNacimientoProfesional
        {
            get => FechaNacimiento;
            set => FechaNacimiento = value;
        }

        public string EmailProfesional
        {
            get => Email;
            set => Email = value;
        }

        public string TelefonoProfesional
        {
            get => Telefono;
            set => Telefono = value;
        }

        public string MatriculaProfesional
        {
            get => Matricula;
            set => Matricula = value;
        }
    }

}
