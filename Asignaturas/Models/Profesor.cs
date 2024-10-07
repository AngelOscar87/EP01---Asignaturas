namespace WebApplication1.Models;

public class Profesor
{
    [Key]
    public int ProfesorId { get; set; }

    [Required]
    [StringLength(100)]
    public string Nombre { get; set; }

    [Required]
    [StringLength(100)]
    public string Apellido { get; set; }

    [Required]
    [StringLength(20)]
    public string NumeroMaestro { get; set; }
}