namespace WebApplication1.Models;

public class Estudiantes
{
    [Key]
    public int EstudianteId { get; set; }

    [Required]
    [StringLength(100)]
    public string Nombre { get; set; }

    [Required]
    [StringLength(100)]
    public string Apellido { get; set; }

    [Required]
    [StringLength(20)]
    public string Matricula { get; set; }

    [Required]
    [StringLength(20)]
    public string Periodo { get; set; }
}