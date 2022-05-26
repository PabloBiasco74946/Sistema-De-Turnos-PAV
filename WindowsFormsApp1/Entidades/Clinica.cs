using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    class Clinica
    {
        private string Razon;
        private string Nombre;
        private int Id_Clinica;
        private int Id_Barrio;
        private string Numero;
        private string Calle;




        public Clinica(string razon, string nombre, int idClinica, int idBarrio, string numero, string calle)
        {

            Nombre = nombre;
            Razon = razon;
            Id_Clinica = idClinica;
            Id_Barrio = idBarrio;
            Numero = numero;
            Calle = calle;
        }


        public Clinica()
        {

        }

        public string RazonDeClinica
        {
            get => Razon;
            set => Razon = value;
        }


        public string NombreDeClinica
        {
            get => Nombre;
            set => Nombre = value;
        }

        public int IdDeClinica
        {
            get => Id_Clinica;
            set => Id_Clinica = value;
        }

        public int IdDeBarrio
        {
            get => Id_Barrio;
            set => Id_Barrio = value;
        }

        public string NumeroDeClinica
        {
            get => Numero;
            set => Numero = value;
        }

        public string CalleClinica
        {
            get => Calle;
            set => Calle = value;
        }
    }
}
