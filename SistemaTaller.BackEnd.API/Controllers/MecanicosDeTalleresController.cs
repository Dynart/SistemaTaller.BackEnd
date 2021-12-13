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
    public class MecanicosDeTalleresController : ControllerBase
    {
        private readonly IMecanicosDeTalleresService MecanicosDeTalleres;
        public MecanicosDeTalleresController(IMecanicosDeTalleresService mecanicosDeTalleresService)
        {
            MecanicosDeTalleres = mecanicosDeTalleresService;
        }

        // GET: api/<MecanicosDeTalleresController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MecanicosDeTalleresController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            MecanicosDeTalleres mecanicosDeTallerSelect = new();
            mecanicosDeTallerSelect = MecanicosDeTalleres.SeleccionarPorId(id);

            if (mecanicosDeTallerSelect.CedulaMecanico is null)
            {
                return NotFound("El Mecanico de Taller No Existe");
            }
            MecanicosDeTalleresDto mecanicosDeTalleresDto = new();
            mecanicosDeTalleresDto.CedulaMecanico = mecanicosDeTallerSelect.CedulaMecanico;
            mecanicosDeTalleresDto.CedulaJuridica = mecanicosDeTallerSelect.CedulaJuridica;
            mecanicosDeTalleresDto.Activo = mecanicosDeTallerSelect.Activo;

            return Ok(mecanicosDeTalleresDto);

        }

        // POST api/<MecanicosDeTalleresController>
        [HttpPost]
        public IActionResult Post([FromBody] MecanicosDeTalleresDto MecanicosDeTalleresDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            MecanicosDeTalleres mecanicosDeTalleresSelect = new();

            mecanicosDeTalleresSelect.CedulaMecanico = MecanicosDeTalleresDto.CedulaMecanico;
            mecanicosDeTalleresSelect.CedulaJuridica = MecanicosDeTalleresDto.CedulaJuridica;

            mecanicosDeTalleresSelect.CreadoPor = "Dynart";

            MecanicosDeTalleres.Insertar(mecanicosDeTalleresSelect);
            return Ok();

        }

        // PUT api/<MecanicosDeTalleresController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MecanicosDeTalleresController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
