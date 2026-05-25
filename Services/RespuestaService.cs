using ApiPreguntas.Enums;
using ApiPreguntas.Interfaces;
using ApiPreguntas.Models;
using ApiPreguntas.Persistence;

namespace ApiPreguntas.Services;

public class RespuestaService : IRespuestaService
{
    private readonly ApplicationDbContext _context;

    public RespuestaService(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<Respuesta> Create(Respuesta respuesta)
    {
        if (await ChangeStatus(respuesta.PreguntaId))
        {
            _context.Respuestas.Add(respuesta);
            await _context.SaveChangesAsync();
            return respuesta;
        }

        return null;
    }
    
    private async Task<bool> ChangeStatus(Guid id)
    {
        var pregunta = _context.Preguntas.FindAsync(id).Result;
        if (pregunta != null)
        {
            pregunta.Estado = Estado.Resuleta;
            return true;
        }

        return false;
    }
}