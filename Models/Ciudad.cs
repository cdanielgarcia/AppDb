using System.ComponentModel.DataAnnotations;

namespace WebAppConDbG1.Models
{
    public class Ciudad
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Código")]
        public string? Codigo { get; set; }

        public string? Nombre { get; set; }

        [Display(Name = "Departamento")]
        public int DeptoId { get; set; }

        public ICollection<Persona>? Personas { get; set; }

        public Dpto? Dpto { get; set; }
    }
}
