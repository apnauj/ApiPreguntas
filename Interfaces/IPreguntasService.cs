using ApiPreguntas.Models;
using ApiPreguntas.Models.DTOs;

namespace ApiPreguntas.Interfaces;

public interface IPreguntasService
{
    public Task<Pregunta> Create(PreguntaCreateDto preguntaCreateDto);
    public Task<List<PreguntaReadDto>> GetAll();
}