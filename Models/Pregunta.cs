using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApiPreguntas.Enums;

namespace ApiPreguntas.Models;

public class Pregunta
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    
    [Required]
    public required string Enunciado { get; set; }
    
    [Required]
    public Categoria Categoria { get; set; }

    [Required]
    public Estado Estado { get; set; } = Estado.SinResolver;
}