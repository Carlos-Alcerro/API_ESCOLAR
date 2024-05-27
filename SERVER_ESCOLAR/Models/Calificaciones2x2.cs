using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Calificaciones2x2
    {
        public int IdAlumno { get; set; }
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int IdAsignatura { get; set; }
        public int Promedio { get; set; }
        public int IdSemestre { get; set; }
        public int AisgnaturaRetrasada { get; set; }
    }
}
