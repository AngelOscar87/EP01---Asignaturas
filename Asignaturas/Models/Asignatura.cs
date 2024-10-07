namespace WebApplication1.Models;

public class Asignatura
{
    [Key]
    public int AsignaturaId { get; set; }

    [Required]
    [StringLength(100)]
    public string Nombre { get; set; }

    [Required]
    public int Creditos { get; set; }

    [Required]
    [StringLength(50)]
    public string Horario { get; set; }

    [Required] [StringLength(100)] public string Profesor { get; set; }
}