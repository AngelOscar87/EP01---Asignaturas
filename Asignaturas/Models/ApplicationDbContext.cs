using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;;

namespace WebApplication1.Models;
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
    }
}