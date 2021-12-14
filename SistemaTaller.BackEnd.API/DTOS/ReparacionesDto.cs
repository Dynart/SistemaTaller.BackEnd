using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.DTOS
{
    public class ReparacionesDto
    {
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
        [MaxLength(15, ErrorMessage = "{0} tiene que tener maximo {1} caracteres")]
        public int NumeroReparacion { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
       
        public DateTime? FechaEstimadaDeReparacion { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
       
        public decimal? MontoManoDeObra { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
      
        public decimal? MontoRepuestos { get; set; }

        public decimal? MontoTotal { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
        [MaxLength(15, ErrorMessage = "{0} tiene que tener maximo {1} caracteres")]
        public string CedulaMecanico { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
        [MaxLength(15, ErrorMessage = "{0} tiene que tener maximo {1} caracteres")]
        public string Matricula { get; set; }

        public int IdEstadoReparacion { get; set; }

        public bool Activo { get; set; }

    }
}
