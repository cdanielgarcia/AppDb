using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppConDbG1.Models;

namespace WebAppConDbG1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Persona>? Personas { get; set; }

        public DbSet<Estudiante>? Estudiantes { get; set; }

        public DbSet<Programa>? Programas { get; set; }

        public DbSet<Dpto>? Dptos { get; set; }

        public DbSet<Ciudad>? Ciudades { get; set; }
    }
}