using Microsoft.AspNetCore.Mvc;
using SistemaTaller.BackEnd.API.DTOS;
using SistemaTaller.BackEnd.API.Models;
using SistemaTaller.BackEnd.API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SistemaTaller.BackEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepuestosController : ControllerBase
    {
        private readonly IRepuestosService Repuestos;
        public RepuestosController(IRepuestosService repuestosService)
        {
            Repuestos = repuestosService;
        }

        // GET: api/<RepuestosController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<RepuestosController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            Repuestos repuestosSelect = new();
            repuestosSelect = Repuestos.SeleccionarPorId(id);

            if (repuestosSelect.CodigoRepuesto is null)
            {
                return NotFound("El Repuesto No Existe");
            }

            RepuestosDto repuestosDto = new();
            repuestosDto.CodigoRepuesto = repuestosSelect.CodigoRepuesto;
            repuestosDto.Marca = repuestosSelect.Marca;
            repuestosDto.Tipo = repuestosSelect.Tipo;
            repuestosDto.FechaCompra = repuestosSelect.FechaCompra;
            repuestosDto.Precio = repuestosSelect.Precio;
            repuestosDto.Activo = repuestosSelect.Activo;

            return Ok(repuestosDto);
        }

        // POST api/<RepuestosController>
        [HttpPost]
        public IActionResult Post([FromBody] RepuestosDto RepuestosDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            Repuestos repuestosSelect = new();

            repuestosSelect.CodigoRepuesto = RepuestosDto.CodigoRepuesto;
            repuestosSelect.Marca = RepuestosDto.Marca;
            repuestosSelect.Tipo = RepuestosDto.Tipo;
            repuestosSelect.FechaCompra = Convert.ToDateTime(RepuestosDto.FechaCompra);
            repuestosSelect.Precio = RepuestosDto.Precio;

            repuestosSelect.CreadoPor = "Dynart";

            Repuestos.Insertar(repuestosSelect);
            return Ok();
        }

        // PUT api/<RepuestosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RepuestosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
