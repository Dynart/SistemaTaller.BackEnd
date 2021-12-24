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
    public class RepuestosDeReparacionesController : ControllerBase
    {
        private readonly IRepuestosDeReparacionesService RepuestosDeReparaciones;
        public RepuestosDeReparacionesController(IRepuestosDeReparacionesService repuestoService)
        {
            RepuestosDeReparaciones = repuestoService;
        }
        // GET: api/<RepuestosDeReparacionesController>
        [HttpGet]
        public List<RepuestosDeReparacionesDto> Get()
        {
            List<RepuestosDeReparaciones> lisRepuestosDeReparaciones = RepuestosDeReparaciones.SeleccionarTodos();

            List<RepuestosDeReparacionesDto> lisRepuestosDeReparacionesDto = new();

            foreach (var repuestoSelect in lisRepuestosDeReparaciones)
            {
                RepuestosDeReparacionesDto repuestosDeReparacionesDto = new();

                repuestosDeReparacionesDto.CodigoRepuesto = repuestoSelect.CodigoRepuesto;
                repuestosDeReparacionesDto.NumeroReparacion = repuestoSelect.NumeroReparacion;
                repuestosDeReparacionesDto.PrecioRepuesto = repuestoSelect.PrecioRepuesto;

                lisRepuestosDeReparacionesDto.Add(repuestosDeReparacionesDto);
            }
            return lisRepuestosDeReparacionesDto;
        }

        // GET api/<RepuestosDeReparacionesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            RepuestosDeReparaciones repuestoSelect = new();
            repuestoSelect = RepuestosDeReparaciones.SeleccionarPorId(id);

            if (repuestoSelect.CodigoRepuesto is null)
            {
                return NotFound("El Repuesto No Existe");
            }

            RepuestosDeReparacionesDto repuestosDeReparacionesDto = new();

            repuestosDeReparacionesDto.CodigoRepuesto = repuestoSelect.CodigoRepuesto;
            repuestosDeReparacionesDto.NumeroReparacion = repuestoSelect.NumeroReparacion;
            repuestosDeReparacionesDto.PrecioRepuesto = repuestoSelect.PrecioRepuesto;
            repuestosDeReparacionesDto.Activo = repuestoSelect.Activo;

            return Ok(repuestosDeReparacionesDto);

        }

        // POST api/<RepuestosDeReparacionesController>
        [HttpPost]
        public IActionResult Post([FromBody] RepuestosDeReparacionesDto RepuestosDeReparacionesDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }
            RepuestosDeReparaciones repuestosSelect = new();
            repuestosSelect.CodigoRepuesto = RepuestosDeReparacionesDto.CodigoRepuesto;
            repuestosSelect.NumeroReparacion = RepuestosDeReparacionesDto.NumeroReparacion;
            repuestosSelect.PrecioRepuesto = RepuestosDeReparacionesDto.PrecioRepuesto;

            repuestosSelect.CreadoPor = "Dynart";

            RepuestosDeReparaciones.Insertar(repuestosSelect);

            return Ok();
        }

        // PUT api/<RepuestosDeReparacionesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RepuestosDeReparacionesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
