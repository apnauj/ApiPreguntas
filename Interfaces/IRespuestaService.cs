using ApiPreguntas.Models;

namespace ApiPreguntas.Interfaces;

public interface IRespuestaService
{
    public Task<Respuesta> Create(Respuesta respuesta);
}