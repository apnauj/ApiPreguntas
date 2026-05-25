using ApiPreguntas.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiPreguntas.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

    public DbSet<Pregunta> Preguntas { get; set; }
    public DbSet<Respuesta> Respuestas { get; set; }
}