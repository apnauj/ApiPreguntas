using ApiPreguntas.Enums;
using ApiPreguntas.Interfaces;
using ApiPreguntas.Models;
using ApiPreguntas.Models.DTOs;
using ApiPreguntas.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ApiPreguntas.Services;

public class PreguntasService : IPreguntasService
{
    private readonly ApplicationDbContext _context;

    public PreguntasService(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<Pregunta> Create(PreguntaCreateDto preguntaCreateDto)
    {
        var pregunta = new Pregunta
        {
            Enunciado = preguntaCreateDto.Enunciado,
            Categoria = preguntaCreateDto.Categoria
        };

        var result = _context.Preguntas.Add(pregunta);
        await _context.SaveChangesAsync();
        return pregunta;
    }

    public async Task<List<Pregunta>> GetByEstado(Estado estado)
    {
        return await _context.Preguntas.Where(p => p.Estado == estado).ToListAsync();
    }
}