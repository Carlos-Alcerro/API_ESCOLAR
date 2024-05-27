using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Calificaciones4x4
    {
        public int IdAlumno { get; set; }
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
        public int Nota4 { get; set; }
        public int IdAsignatura { get; set; }
        public int Promedio { get; set; }
        public int IdSemestre { get; set; }
        public int AisgnaturaRetrasada { get; set; }
    }
}
