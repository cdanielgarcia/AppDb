using System.ComponentModel.DataAnnotations;

namespace WebAppConDbG1.Models
{
    public class Programa
    {
        public int Id { get; set; }

        [MaxLength(35)]
        public string? Nombre { get; set; }

        public int Niveles { get; set; }

        public ICollection<Estudiante>? Estudiantes { get; set; }

    }

}
