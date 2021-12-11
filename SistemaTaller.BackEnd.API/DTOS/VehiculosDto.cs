using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.DTOS
{
    public class VehiculosDto
    {
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
        [MaxLength(10, ErrorMessage = "{0} tiene mque tener maximo {1} caracteres")]
       
        public string Matricula { get; set; }
       
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
        [MaxLength(10, ErrorMessage = "{0} tiene mque tener maximo {1} caracteres")]
       
        public string MarcaVehiculo { get; set; }

        [Required(ErrorMessage = "{0} es un campo obligatorio")]
        [MaxLength(10, ErrorMessage = "{0} tiene mque tener maximo {1} caracteres")]
       
        public string Modelo { get; set; }

        public bool Activo { get; set; }

    }
}
