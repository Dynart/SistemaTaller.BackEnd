using Microsoft.AspNetCore.Mvc;
using SistemaTaller.BackEnd.API.Models;
using SistemaTaller.BackEnd.API.Services.Interfaces;
using SistemaTaller.BackEnd.API.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SistemaTaller.BackEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClientesService Clientes;
        public ClientesController(IClientesService clientesService)
        {
            Clientes = clientesService;
        }
        // GET: api/<ClientesController>
        [HttpGet]
        public List<ClientesDto> Get()
        {
            List<Clientes> lisClientes = Clientes.SeleccionarTodos();

            List<ClientesDto> lisClientesDto = new List<ClientesDto>();

            foreach (var clienteSelect in lisClientes)
            {
                ClientesDto clientesDto = new();

                clientesDto.CedulaCliente = clientesDto.CedulaCliente;

                lisClientesDto.Add(clientesDto);

            }
            return lisClientesDto;

        }

        // GET api/<ClientesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            Clientes clientesSelect = new();
            clientesSelect = Clientes.SeleccionarPorId(id);

            if (clientesSelect.CedulaCliente is null)
            {
                return NotFound("El Cliente No Existe");
            }

            ClientesDto clientesDto = new();
            clientesDto.CedulaCliente = clientesSelect.CedulaCliente;
            clientesDto.Nombre = clientesSelect.Nombre;
            clientesDto.Apellidos = clientesSelect.Apellidos;
            clientesDto.Telefono = clientesSelect.Telefono;
            clientesDto.Email = clientesSelect.Email;
            clientesDto.Direccion = clientesSelect.Direccion;
            clientesDto.VehiculoMatricula = clientesSelect.VehiculoMatricula;
            clientesDto.Activo = clientesSelect.Activo;

            return Ok(clientesDto);
        }

        // POST api/<ClientesController>
        [HttpPost]
        public IActionResult Post([FromBody] ClientesDto ClientesDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            Clientes clientesSelect = new();
            clientesSelect.CedulaCliente = ClientesDto.CedulaCliente;
            clientesSelect.Nombre = ClientesDto.Nombre;
            clientesSelect.Apellidos = ClientesDto.Apellidos;
            clientesSelect.Telefono = ClientesDto.Telefono;
            clientesSelect.Email = ClientesDto.Email;
            clientesSelect.Direccion = ClientesDto.Direccion;
            clientesSelect.VehiculoMatricula = ClientesDto.VehiculoMatricula;

            clientesSelect.CreadoPor = "Dynart";

            Clientes.Insertar(clientesSelect);

            return Ok();
        }

        // PUT api/<ClientesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] ClientesDto clientesDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            Clientes clientesSelect = new();

            clientesSelect = Clientes.SeleccionarPorId(id);

            if (clientesSelect.CedulaCliente is null)
            {
                return NotFound("El Cliente no existe");
            }

            Clientes clientesUpdate = new();

            clientesUpdate.CedulaCliente = clientesDto.CedulaCliente;
            clientesUpdate.Nombre = clientesDto.Nombre;
            clientesUpdate.Apellidos = clientesDto.Apellidos;
            clientesUpdate.Telefono = clientesDto.Telefono;
            clientesUpdate.Email = clientesDto.Email;
            clientesUpdate.Direccion = clientesDto.Direccion;
            clientesUpdate.VehiculoMatricula = clientesDto.VehiculoMatricula;

            clientesSelect.FechaModificacion = System.DateTime.Now;
            clientesSelect.ModificadoPor = "Dynart";

            Clientes.Actualizar(clientesUpdate);

            return Ok();
        }

        // DELETE api/<ClientesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
