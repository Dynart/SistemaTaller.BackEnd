using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.DTOS
{
    public class VehiculosDeClientesDto
    {
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
        [MaxLength(15, ErrorMessage = "{0} tiene que tener maximo {1} caracteres")]
        public string Matricula { get; set; }
        [Required(ErrorMessage = "{0} es un campo obligatorio")]
        [MaxLength(15, ErrorMessage = "{0} tiene que tener maximo {1} caracteres")]
        public string CedulaCliente { get; set; }
       
        public bool Activo { get; set; }


    }

}
