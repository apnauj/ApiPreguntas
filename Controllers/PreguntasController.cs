using ApiPreguntas.Enums;
using ApiPreguntas.Interfaces;
using ApiPreguntas.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPreguntas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PreguntasController : ControllerBase
    {
        private readonly IPreguntasService _preguntasService;

        public PreguntasController(IPreguntasService preguntasService)
        {
            _preguntasService = preguntasService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PreguntaCreateDto preguntaCreateDto)
        {
            return Ok(await _preguntasService.Create(preguntaCreateDto));
        }

        [HttpGet("{estado}")]
        public async Task<IActionResult> GetByStatus(Estado estado)
        {
            return Ok(await _preguntasService.GetByEstado(estado));
        }
    }
}
