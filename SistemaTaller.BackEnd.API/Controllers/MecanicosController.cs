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
    public class MecanicosController : ControllerBase
    {
        private readonly IMecanicosService Mecanicos;
        public MecanicosController(IMecanicosService mecanicosService)
        {
            Mecanicos = mecanicosService;
        }
        // GET: api/<MecanicosController>
        [HttpGet]
        public List<MecanicosDto> Get()
        {
            List<Mecanicos> lisMecanicos = Mecanicos.SeleccionarTodos();

            List<MecanicosDto> lisMecanicosDto = new();

            foreach (var mecanicosSelect in lisMecanicos)
            {
                MecanicosDto mecanicosDto = new();

                mecanicosDto.CedulaMecanico = mecanicosSelect.CedulaMecanico;
                mecanicosDto.Nombre = mecanicosSelect.Nombre;
                mecanicosDto.Apellidos = mecanicosSelect.Apellidos;
                mecanicosDto.Telefono = mecanicosSelect.Telefono;
                mecanicosDto.Salario = mecanicosSelect.Salario;

                lisMecanicosDto.Add(mecanicosDto);
            }
            return lisMecanicosDto;
        }

        // GET api/<MecanicosController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            Mecanicos mecanicosSelect = new();
            mecanicosSelect = Mecanicos.SeleccionarPorId(id);

            if (mecanicosSelect.CedulaMecanico is null)
            {
                return NotFound("Ese Mecanico Que Esta Insertando Ni Se Conoce");
            }

            MecanicosDto mecanicosDto = new();

            mecanicosDto.CedulaMecanico = mecanicosSelect.CedulaMecanico;
            mecanicosDto.Nombre = mecanicosSelect.Nombre;
            mecanicosDto.Apellidos = mecanicosSelect.Apellidos;
            mecanicosDto.Telefono = mecanicosSelect.Telefono;
            mecanicosDto.Salario = mecanicosSelect.Salario;
            mecanicosDto.Activo = mecanicosSelect.Activo;

            return Ok(mecanicosDto);



        }

        // POST api/<MecanicosController>
        [HttpPost]
        public IActionResult Post([FromBody] MecanicosDto MecanicosDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            Mecanicos mecanicosSelect = new();
            mecanicosSelect.CedulaMecanico = MecanicosDto.CedulaMecanico;
            mecanicosSelect.Nombre = MecanicosDto.Nombre;
            mecanicosSelect.Apellidos = MecanicosDto.Apellidos;
            mecanicosSelect.Telefono = MecanicosDto.Telefono;
            mecanicosSelect.Salario = MecanicosDto.Salario;

            mecanicosSelect.CreadoPor = "Dynart";

            Mecanicos.Insertar(mecanicosSelect);

            return Ok();

        }

        // PUT api/<MecanicosController>/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] MecanicosDto mecanicosDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            Mecanicos mecanicosSelect = new Mecanicos();

            mecanicosSelect = Mecanicos.SeleccionarPorId(id);

            if (mecanicosSelect.CedulaMecanico is null)
            {
                return NotFound("El MEcanico no existe");
            }

            Mecanicos mecanicosUpdate = new();

            mecanicosUpdate.CedulaMecanico = mecanicosDto.CedulaMecanico;
            mecanicosUpdate.Nombre = mecanicosDto.Nombre;
            mecanicosUpdate.Apellidos = mecanicosDto.Apellidos;
            mecanicosUpdate.Telefono = mecanicosDto.Telefono;
            mecanicosUpdate.Salario = mecanicosDto.Salario;

            mecanicosUpdate.FechaModificacion = System.DateTime.Now;
            mecanicosUpdate.ModificadoPor = "Dynart";

            Mecanicos.Actualizar(mecanicosUpdate);

            return Ok();

        }

        // DELETE api/<MecanicosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
