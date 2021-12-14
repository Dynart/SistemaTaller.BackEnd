using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.DTOS
{
    public class RepuestosDto
    {
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
        [MaxLength(15, ErrorMessage = "{0} tiene que tener maximo {1} caracteres")]
        public string CodigoRepuesto { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
        [MaxLength(15, ErrorMessage = "{0} tiene que tener maximo {1} caracteres")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
        [MaxLength(15, ErrorMessage = "{0} tiene que tener maximo {1} caracteres")]
        public string Tipo { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
        public DateTime FechaCompra { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
        public decimal? Precio { get; set; }

        public bool Activo { get; set; }

    }
}
