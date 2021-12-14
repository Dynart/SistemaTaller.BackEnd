using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Models
{
    public class Reparaciones
    {
        public int NumeroReparacion { get; set; }

        public DateTime? FechaEstimadaDeReparacion { get; set; }

        public decimal? MontoManoDeObra { get; set; }

        public decimal? MontoRepuestos { get; set; }

        public decimal? MontoTotal { get; set; }

        public string CedulaMecanico { get; set; }

        public string Matricula { get; set; }

        public int IdEstadoReparacion { get; set; }

        public bool Activo { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public string CreadoPor { get; set; }

        public string ModificadoPor { get; set; }

    }
}
