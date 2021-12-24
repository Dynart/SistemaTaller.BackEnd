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
    public class TalleresController : ControllerBase
    {
        private readonly ITalleresService Talleres;
        public TalleresController(ITalleresService talleresService)
        {
            Talleres = talleresService;
        }
        // GET: api/<TalleresController>
        [HttpGet]
        public List<TalleresDto> Get()
        {
            List<Talleres> lisTalleres = Talleres.SeleccionarTodos();

            List<TalleresDto> lisTalleresDto = new();

            foreach (var talleresSelect in lisTalleres)
            {
                TalleresDto talleresDto = new();

                talleresDto.CedulaJuridica = talleresSelect.CedulaJuridica;
                talleresDto.Nombre = talleresSelect.Nombre;
                talleresDto.Direccion = talleresSelect.Direccion;
                talleresDto.Telefono = talleresSelect.Telefono;

                lisTalleresDto.Add(talleresDto);
            }
            return lisTalleresDto;
        }

        // GET api/<TalleresController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            Talleres talleresSelect = new();
            talleresSelect = Talleres.SeleccionarPorId(id);

            if (talleresSelect.CedulaJuridica is null)
            {
                return NotFound("El Taller No Existe");
            }
            TalleresDto talleresDto = new();
            talleresDto.CedulaJuridica = talleresSelect.CedulaJuridica;
            talleresDto.Nombre = talleresSelect.Nombre;
            talleresDto.Direccion = talleresSelect.Direccion;
            talleresDto.Telefono = talleresSelect.Telefono;
            talleresDto.Activo = talleresSelect.Activo;

            return Ok(talleresDto);
        }

        // POST api/<TalleresController>
        [HttpPost]
        public IActionResult Post([FromBody] TalleresDto TalleresDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            Talleres talleresSelect = new();

            talleresSelect.CedulaJuridica = talleresSelect.CedulaJuridica;
            talleresSelect.Nombre = talleresSelect.Nombre;
            talleresSelect.Direccion = talleresSelect.Direccion;
            talleresSelect.Telefono = talleresSelect.Telefono;

            talleresSelect.CreadoPor = "Dynart";

            Talleres.Insertar(talleresSelect);

            return Ok();
        }

        // PUT api/<TalleresController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TalleresController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
