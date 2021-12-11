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
    public class VehiculosController : ControllerBase
    {
        private readonly IVehiculosService Vehiculos;
        public VehiculosController (IVehiculosService VehiculosService)
        {
            Vehiculos = VehiculosService;
        }
        // GET: api/<VehiculosController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<VehiculosController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            Vehiculos VehiculosSelect = new();

            VehiculosSelect = Vehiculos.SeleccionarPorId(id);

            if (VehiculosSelect.Matricula is null)
            {
                return NotFound("El Vehiculo No Existe");
            }

            VehiculosDto vehiculosDto = new();
            vehiculosDto.Matricula = VehiculosSelect.Matricula;
            vehiculosDto.MarcaVehiculo = VehiculosSelect.MarcaVehiculo;
            vehiculosDto.Modelo = VehiculosSelect.Modelo;
            vehiculosDto.Activo = VehiculosSelect.Activo;

            return Ok(vehiculosDto);
        }

        // POST api/<VehiculosController>
        [HttpPost]
        public IActionResult Post([FromBody] VehiculosDto VehiculosDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }
            Vehiculos VehiculosInsert = new();

            VehiculosInsert.Matricula = VehiculosDto.Matricula;
            VehiculosInsert.MarcaVehiculo = VehiculosDto.MarcaVehiculo;
            VehiculosInsert.Modelo = VehiculosDto.Modelo;

            VehiculosInsert.CreadoPor = "Dynart";

            Vehiculos.Insertar(VehiculosInsert);

            return Ok();
        }

        // PUT api/<VehiculosController>/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] VehiculosDto vehiculosDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            Vehiculos vehiculosSelect = new();

            vehiculosSelect = Vehiculos.SeleccionarPorId(id);

            if (vehiculosSelect.Matricula is null)
            {
                return NotFound("Vehiculo no existe");
            }

            Vehiculos vehiculosUpdate = new();
            vehiculosUpdate.Matricula = vehiculosDto.Matricula;
            vehiculosUpdate.MarcaVehiculo = vehiculosDto.MarcaVehiculo;
            vehiculosUpdate.Modelo = vehiculosDto.Modelo;
            vehiculosUpdate.Activo = vehiculosDto.Activo;

            vehiculosUpdate.FechaModificacion = System.DateTime.Now;
            vehiculosUpdate.ModificadoPor = "Dynart";

            Vehiculos.Actualizar(vehiculosUpdate);

            return Ok();
        }

        // DELETE api/<VehiculosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
