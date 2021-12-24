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
    public class EstadoReparacionesController : ControllerBase
    {
        private readonly IEstadoReparacionesService EstadoReparaciones;
        public EstadoReparacionesController(IEstadoReparacionesService estadoService)
        {
            EstadoReparaciones = estadoService;
        }

        // GET: api/<EstadoReparacionesController>
        [HttpGet]
        public List<EstadoReparacionesDto> Get()
        {
            List<EstadoReparaciones> lisEstado = EstadoReparaciones.SeleccionarTodos();

            List<EstadoReparacionesDto> lisEstadoDto = new();

            foreach (var estadoSelect in lisEstado)
            {
                EstadoReparacionesDto estadoReparacionesDto = new();
                estadoReparacionesDto.IdEstadoReparacion = estadoSelect.IdEstadoReparacion;
                estadoReparacionesDto.NombreEstado = estadoSelect.NombreEstado;

                lisEstadoDto.Add(estadoReparacionesDto);
            }
            return lisEstadoDto;
        }

        // GET api/<EstadoReparacionesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            EstadoReparaciones estadoSelect = new();
            estadoSelect = EstadoReparaciones.SeleccionarPorId(id);

            EstadoReparacionesDto estadoReparacionesDto = new();
            estadoReparacionesDto.IdEstadoReparacion = estadoSelect.IdEstadoReparacion;
            estadoReparacionesDto.NombreEstado = estadoSelect.NombreEstado;
            estadoReparacionesDto.Activo = estadoSelect.Activo;

            return Ok(estadoReparacionesDto);
        }

        // POST api/<EstadoReparacionesController>
        [HttpPost]
        public IActionResult Post([FromBody] EstadoReparacionesDto EstadoReparacionesDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            EstadoReparaciones estadoSelect = new();
            estadoSelect.IdEstadoReparacion = EstadoReparacionesDto.IdEstadoReparacion;
            estadoSelect.NombreEstado = EstadoReparacionesDto.NombreEstado;

            estadoSelect.CreadoPor = "Dynart";

            EstadoReparaciones.Insertar(estadoSelect);

            return Ok();
        }

        // PUT api/<EstadoReparacionesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EstadoReparacionesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
