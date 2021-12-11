using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.DTOS
{
    public class MecanicosDto
    {
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
        [MaxLength(15, ErrorMessage = "{0} tiene que tener maximo {1} caracteres")]
        public string CedulaMecanico { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
        [MaxLength(40, ErrorMessage = "{0} tiene que tener maximo {1} caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
        [MaxLength(50, ErrorMessage = "{0} tiene que tener maximo {1} caracteres")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
        [MaxLength(10, ErrorMessage = "{0} tiene que tener maximo {1} caracteres")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
        public decimal? Salario { get; set; }
        
        public bool Activo { get; set; }

    }
}
