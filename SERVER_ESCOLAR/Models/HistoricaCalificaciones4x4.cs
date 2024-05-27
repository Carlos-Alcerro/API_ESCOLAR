using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class HistoricaCalificaciones4x4
    {
        public int IdAlumno { get; set; }
        public int IdSequencia { get; set; }
        public int Nota1{ get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
        public int Nota4 { get; set; }

        [MaxLength(50,ErrorMessage = "El campo Secion debe tener maximo 50 caracteres ")]
        [MinLength(5,ErrorMessage = "El campo Secion no debe tener menos de 5 caracteres")]
        public string Secion { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo Grado debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo Grado no debe tener menos de 5 caracteres")]
        public string Grado { get; set; } = null!;
    }
}
