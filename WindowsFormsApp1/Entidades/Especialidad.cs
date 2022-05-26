using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    class Especialidad
    {
        private int Id_Especialidades;
        private string Nombre;
        private string Descripcion;


        public Especialidad()
        {

        }
        public Especialidad(int idEspecialidad, string nombre, string descripcion)
        {
            Id_Especialidades = idEspecialidad;
            Nombre = nombre;
            Descripcion = descripcion ;
        }

        public int IdDeEspecialidades
        {
            get => Id_Especialidades;
            set => Id_Especialidades = value;
        }

        public string NombreDeEspecialidad
        {
            get => Nombre;
            set => Nombre = value;
        }
        public string DescripcionEspecialidad
        {
            get => Descripcion;
            set => Descripcion = value;
        }
    }

}

