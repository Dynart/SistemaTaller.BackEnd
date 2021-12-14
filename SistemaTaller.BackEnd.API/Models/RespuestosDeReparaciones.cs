using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Models
{
    public class RepuestosDeReparaciones
    {
        public string CodigoRepuesto { get; set; }

        public int NumeroReparacion { get; set; }

        public decimal? PrecioRepuesto { get; set; }

        public bool Activo { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public string CreadoPor { get; set; }

        public string ModificadoPor { get; set; }

    }
}
