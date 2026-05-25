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
    public required string Contenido { get; set; }
    
    [Required]
    public Guid PreguntaId { get; set; }
    
    [ForeignKey(nameof(PreguntaId))]
    public Pregunta Pregunta { get; set; }
    
    [Required]
    public DateTime FechaDeCreacion { get; set; } = DateTime.UtcNow;
}