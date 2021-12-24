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
    public class ReparacionesController : ControllerBase
    {
        private readonly IReparacionesService Reparaciones;
        public ReparacionesController(IReparacionesService reparacionesService)
        {
            Reparaciones = reparacionesService;
        }

        // GET: api/<ReparacionesController>
        [HttpGet]
        public List<ReparacionesDto> Get()
        {
            List<Reparaciones> lisReparaciones = Reparaciones.SeleccionarTodos();

            List<ReparacionesDto> lisReparacionesDto = new();

            foreach (var reparacionesSelect in lisReparaciones)
            {
                ReparacionesDto reparacionesDto = new();

                reparacionesDto.NumeroReparacion = reparacionesSelect.NumeroReparacion;
                reparacionesDto.FechaEstimadaDeReparacion = reparacionesSelect.FechaEstimadaDeReparacion;
                reparacionesDto.MontoManoDeObra = reparacionesSelect.MontoManoDeObra;
                reparacionesDto.MontoRepuestos = reparacionesSelect.MontoRepuestos;
                reparacionesDto.MontoTotal = reparacionesSelect.MontoTotal;
                reparacionesDto.CedulaMecanico = reparacionesSelect.CedulaMecanico;
                reparacionesDto.Matricula = reparacionesSelect.Matricula;
                reparacionesDto.IdEstadoReparacion = reparacionesSelect.IdEstadoReparacion;

                lisReparacionesDto.Add(reparacionesDto);
            }
            return lisReparacionesDto;
        }

        // GET api/<ReparacionesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {

            Reparaciones reparacionesSelect = new();
            reparacionesSelect = Reparaciones.SeleccionarPorId(id);

            if (reparacionesSelect.NumeroReparacion is 0)
            {
                return NotFound("La Reparacion No Existe");
            }

            ReparacionesDto reparacionesDto = new();

            reparacionesDto.NumeroReparacion = reparacionesSelect.NumeroReparacion;
            reparacionesDto.FechaEstimadaDeReparacion = reparacionesSelect.FechaEstimadaDeReparacion;
            reparacionesDto.MontoManoDeObra = reparacionesSelect.MontoManoDeObra;
            reparacionesDto.MontoRepuestos = reparacionesSelect.MontoRepuestos;
            reparacionesDto.MontoTotal = reparacionesSelect.MontoTotal;
            reparacionesDto.CedulaMecanico = reparacionesSelect.CedulaMecanico;
            reparacionesDto.Matricula = reparacionesSelect.Matricula;
            reparacionesDto.IdEstadoReparacion = reparacionesSelect.IdEstadoReparacion;
            reparacionesDto.Activo = reparacionesSelect.Activo;

            return Ok(reparacionesDto);

        }

        // POST api/<ReparacionesController>
        [HttpPost]
        public IActionResult Post([FromBody] ReparacionesDto ReparacionesDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            Reparaciones reparacionesSelect = new();
            
            reparacionesSelect.MontoManoDeObra = ReparacionesDto.MontoManoDeObra;
            reparacionesSelect.MontoRepuestos = ReparacionesDto.MontoRepuestos;
            reparacionesSelect.CedulaMecanico = ReparacionesDto.CedulaMecanico;
            reparacionesSelect.Matricula = ReparacionesDto.Matricula;
            reparacionesSelect.IdEstadoReparacion = ReparacionesDto.IdEstadoReparacion;

            reparacionesSelect.CreadoPor = "Dynart";

            Reparaciones.Insertar(reparacionesSelect);

            return Ok();

        }

        // PUT api/<ReparacionesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] ReparacionesDto reparacionesDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            Reparaciones reparacionesSelect = new();
            reparacionesSelect = Reparaciones.SeleccionarPorId(id);

            if (reparacionesSelect.NumeroReparacion is 0)
            {
                return NotFound("La Reparacion no existe");
            }

            Reparaciones reparacionesUpdate = new();

            reparacionesUpdate.MontoManoDeObra = reparacionesDto.MontoManoDeObra;
            reparacionesUpdate.MontoRepuestos = reparacionesDto.MontoRepuestos;
            reparacionesUpdate.CedulaMecanico = reparacionesDto.CedulaMecanico;
            reparacionesUpdate.Matricula = reparacionesDto.Matricula;
            reparacionesUpdate.IdEstadoReparacion = reparacionesDto.IdEstadoReparacion;

            reparacionesUpdate.FechaModificacion = System.DateTime.Now;
            reparacionesUpdate.ModificadoPor = "Dynart";

            Reparaciones.Actualizar(reparacionesUpdate);
            return Ok();
        }

        // DELETE api/<ReparacionesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
