using System.ComponentModel.DataAnnotations;

namespace ApiPreguntas.Models.DTOs;

public class RespuestaCreateDto
{
    [Required]
    [StringLength(500, MinimumLength = 5, ErrorMessage = "La respuesta debe tener como máximo 500 caracteres y mínimo 5 caracteres")]
    public required string Contenido { get; set; }
    
    [Required]
    public Guid PreguntaId { get; set; }
}