using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    class Arancel
    {
        private int IdArancel;
        private int TipoDocProfesional;
        private string NumDocProfesional;
        private DateTime FechaInicioVigencia;
        private DateTime FechaFinVigencia;
        private string Precio;




        public Arancel()
        {

        }
        public Arancel(int idAranceles, int tipoDocProfesional, string numDocProfesional, DateTime fechaInicio, DateTime fechaFin, string precio)
        {
            IdArancel = idAranceles;
            TipoDocProfesional = tipoDocProfesional;
            NumDocProfesional = numDocProfesional;
            FechaInicioVigencia = fechaInicio;
            FechaFinVigencia = fechaFin;
            Precio = precio;


        }

        public int IdDeAranceles
        {
            get => IdArancel;
            set => IdArancel = value;
        }

        public int TipoDocDeProfesional
        {
            get => TipoDocProfesional;
            set => TipoDocProfesional = value;
        }
        public string NumDocDeProfesional
        {
            get => NumDocProfesional;
            set => NumDocProfesional = value;
        }

        public DateTime FechaDeInicioVigencia
        {
            get => FechaInicioVigencia;
            set => FechaInicioVigencia = value;
        }

        public DateTime FechaDeFinVigencia
        {
            get => FechaFinVigencia;
            set => FechaFinVigencia = value;
        }
        public string PrecioDeArancel
        {
            get => Precio;
            set => Precio = value;
        }

    }
}


