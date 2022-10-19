using System.ComponentModel.DataAnnotations;

namespace WebAppConDbG1.Models
{
    public class Persona
    {
        [Key]

        public int Id { get; set; }

        [MaxLength(15)]
        public string? Documento { get; set; }

        [MaxLength(45)]
        public string? Nombre { get; set; }

        [Display(Name = "Dirección")]
        public string? Dir { get; set; }

        [Display(Name = "Ciudad")]
        public int CiudadId { get; set; }

        [Display(Name = "Teléfono")]
        [MaxLength(15)]
        public string? Telefono { get; set; }

        public string? Email { get; set; }

        public ICollection<Estudiante>? Estudiantes { get; set; }

        public Ciudad? Ciudad { get; set; }

    }
}
