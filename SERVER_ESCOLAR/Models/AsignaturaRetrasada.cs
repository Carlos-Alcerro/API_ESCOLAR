using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class AsignaturaRetrasada
    {
        [Key]
        public int IdAsignaturaRetrasada { get; set; }
        public int IdAlumno { get; set; }
        public int IdGrado{ get; set; }
        public int IdAsignatura { get; set; }

        public decimal Precio;

        [MaxLength(100, ErrorMessage = "El campo observaciones debe tener maximo 100 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo observaciones no debe tener menos de 5 caracteres")]
        public string Estado { get; set; } = null!;

    }
}