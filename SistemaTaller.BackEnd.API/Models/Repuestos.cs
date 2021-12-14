using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Models
{
    public class Repuestos
    {
        public string CodigoRepuesto { get; set; }

        public string Marca { get; set; }

        public string Tipo { get; set; }

        public DateTime FechaCompra { get; set; }

        public decimal? Precio { get; set; }

        public bool Activo { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public string CreadoPor { get; set; }

        public string ModificadoPor { get; set; }

    }
}
