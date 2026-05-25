using ApiPreguntas.Interfaces;
using ApiPreguntas.Models;
using ApiPreguntas.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPreguntas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RespuestasController : ControllerBase
    {
        private readonly IRespuestaService _respuestaService;

        public RespuestasController(IRespuestaService respuestaService)
        {
            _respuestaService = respuestaService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RespuestaCreateDto respuestaCreateDto)
        {
            var result = await _respuestaService.Create(respuestaCreateDto);
            return (result != null) ? Ok(result) : NotFound();
        }
    }
}
