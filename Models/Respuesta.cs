using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApiPreguntas.Enums;

namespace ApiPreguntas.Models;

public class Respuesta
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    
    [Required]
    [StringLength(500, MinimumLength = 5, ErrorMessage = "La respuesta debe tener como máximo 500 caracteres y mínimo 5 caracteres")]
    public required string Contenido { get; set; }
    
    [Required]
    public Guid PreguntaId { get; set; }
    
    [Required]
    [ForeignKey(nameof(PreguntaId))]
    public required Pregunta Pregunta { get; set; }
    
    [Required]
    public DateTime FechaDeCreacion { get; set; } = DateTime.UtcNow;
}