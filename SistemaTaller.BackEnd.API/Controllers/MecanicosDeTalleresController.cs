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
        public List<MecanicosDeTalleresDto> Get()
        {
            List<MecanicosDeTalleres> lisMecanicos = MecanicosDeTalleres.SeleccionarTodos();

            List<MecanicosDeTalleresDto> lisMecanicosDto = new();

            foreach (var mecanicosDeTallerSelect in lisMecanicos)
            {
                MecanicosDeTalleresDto mecanicosDeTalleresDto = new();
                mecanicosDeTalleresDto.CedulaMecanico = mecanicosDeTallerSelect.CedulaMecanico;
                mecanicosDeTalleresDto.CedulaJuridica = mecanicosDeTallerSelect.CedulaJuridica;

                lisMecanicosDto.Add(mecanicosDeTalleresDto);
            }
            return lisMecanicosDto;
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
        public IActionResult Put(string id, [FromBody] MecanicosDeTalleresDto mecanicosDeTalleresDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            MecanicosDeTalleres mecanicosSelect = new();
            mecanicosSelect = MecanicosDeTalleres.SeleccionarPorId(id);

            if (mecanicosSelect.CedulaMecanico is null)
            {
                return NotFound("El Mecanico no existe");
            }

            MecanicosDeTalleres mecanicosUpdate = new();

            mecanicosUpdate.CedulaMecanico = mecanicosDeTalleresDto.CedulaMecanico;
            mecanicosUpdate.CedulaJuridica = mecanicosDeTalleresDto.CedulaJuridica;

            mecanicosUpdate.FechaModificacion = System.DateTime.Now;
            mecanicosUpdate.ModificadoPor = "Dynart";

            MecanicosDeTalleres.Actualizar(mecanicosUpdate);

            return Ok();

        }

        // DELETE api/<MecanicosDeTalleresController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
