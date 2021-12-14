using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.DTOS
{
    public class EstadoReparacionesDto
    {
        public int IdEstadoReparacion { get; set; }

        public string NombreEstado { get; set; }

        public bool Activo { get; set; }


    }
}
