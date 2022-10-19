using System.ComponentModel.DataAnnotations;

namespace WebAppConDbG1.Models
{
    public class Dpto
    {
        public int Id { get; set; }

        [Display(Name = "Código")]
        [MaxLength(25)]
        public string? Codigo { get; set; }

        [MaxLength(25)]
        public string? Nombre { get; set; }

        public ICollection<Ciudad>? Ciudades { get; set; }
    }
}
