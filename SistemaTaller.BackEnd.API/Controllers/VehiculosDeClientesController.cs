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
    public class VehiculosDeClientesController : ControllerBase
    {
        private readonly IVehiculosDeClientesService VehiculosDeClientes;
        public VehiculosDeClientesController(IVehiculosDeClientesService vehiculosDeClientesService)
        {
            VehiculosDeClientes = vehiculosDeClientesService;
        }

        // GET: api/<VehiculosDeClientesController>
        [HttpGet]
        public List<VehiculosDeClientesDto> Get()
        {
            List<VehiculosDeClientes> lisVehiculos = VehiculosDeClientes.SeleccionarTodos();

            List<VehiculosDeClientesDto> lisVehiculosDto = new();

            foreach (var vehiculoSelect in lisVehiculos)
            {
                VehiculosDeClientesDto vehiculosDto = new();

                vehiculosDto.Matricula = vehiculoSelect.Matricula;
                vehiculosDto.CedulaCliente = vehiculoSelect.CedulaCliente;

                lisVehiculosDto.Add(vehiculosDto);
            }
            return lisVehiculosDto;
        }

        // GET api/<VehiculosDeClientesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            VehiculosDeClientes vehiculoSelect = new();
            vehiculoSelect = VehiculosDeClientes.SeleccionarPorId(id);

            if (vehiculoSelect.Matricula is null)
            {
                return NotFound("El Vehiculo No Existe");
            }

            VehiculosDeClientesDto vehiculosDeClientesDto = new();
            vehiculosDeClientesDto.Matricula = vehiculoSelect.Matricula;
            vehiculosDeClientesDto.CedulaCliente = vehiculoSelect.CedulaCliente;
            vehiculosDeClientesDto.Activo = vehiculoSelect.Activo;

            return Ok(vehiculosDeClientesDto);
        }

        // POST api/<VehiculosDeClientesController>
        [HttpPost]
        public IActionResult Post([FromBody] VehiculosDeClientesDto VehiculosDeClientesDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            VehiculosDeClientes vehiculosDeClientesSelect = new();
            vehiculosDeClientesSelect.Matricula = VehiculosDeClientesDto.Matricula;
            vehiculosDeClientesSelect.CedulaCliente = VehiculosDeClientesDto.CedulaCliente;

            vehiculosDeClientesSelect.CreadoPor = "Dynart";

            VehiculosDeClientes.Insertar(vehiculosDeClientesSelect);

            return Ok();


        }

        // PUT api/<VehiculosDeClientesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VehiculosDeClientesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
