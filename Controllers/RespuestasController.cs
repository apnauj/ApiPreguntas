using ApiPreguntas.Interfaces;
using ApiPreguntas.Models;
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
        public async Task<IActionResult> Create([FromBody] Respuesta respuesta)
        {
            var result = await _respuestaService.Create(respuesta);
            return (result != null) ? Ok(result) : NotFound();
        }
    }
}
