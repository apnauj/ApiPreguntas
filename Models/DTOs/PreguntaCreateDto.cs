using System.ComponentModel.DataAnnotations;
using ApiPreguntas.Enums;

namespace ApiPreguntas.Models.DTOs;

public class PreguntaCreateDto
{
    [StringLength(300, MinimumLength = 5, ErrorMessage = "La pregunta debe tener como máximo 300 caracteres y mínimo 5 caracteres")]
    public required string Enunciado { get; set; }
    
    [Required]
    public Categoria Categoria { get; set; }
}