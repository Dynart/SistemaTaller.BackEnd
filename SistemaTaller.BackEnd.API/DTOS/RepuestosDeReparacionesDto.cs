using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.DTOS
{
    public class RepuestosDeReparacionesDto
    {
        public string CodigoRepuesto { get; set; }

        public int NumeroReparacion { get; set; }

        public decimal? PrecioRepuesto { get; set; }

        public bool Activo { get; set; }

    }
}
