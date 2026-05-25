using ApiPreguntas.Models;
using ApiPreguntas.Models.DTOs;

namespace ApiPreguntas.Interfaces;

public interface IRespuestaService
{
    public Task<Respuesta> Create(RespuestaCreateDto respuestaCreateDto);
}