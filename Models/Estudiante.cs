namespace WebAppConDbG1.Models
{
    public class Estudiante
    {
        public int Id { get; set; }

        public int PersonaId { get; set; }

        public int ProgramaId { get; set; }

        public int Nivel { get; set; }

        public Programa? Programa { get; set; }

        public Persona? Persona { get; set; }
    }
}
