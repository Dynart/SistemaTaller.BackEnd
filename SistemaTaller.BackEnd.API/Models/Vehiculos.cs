using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Models
{
    public class Vehiculos
    {
        public string Matricula { get; set; }

        public string MarcaVehiculo { get; set; }

        public string Modelo { get; set; }

        public bool Activo { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public string CreadoPor { get; set; }

        public string ModificadoPor { get; set; }

    }
}
