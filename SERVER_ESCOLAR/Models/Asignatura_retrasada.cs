using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Asignatura_catedratico
    {
        public int id_asignatura_retrasada { get; set; }
        public int id_alumno { get; set; }
        public int id_grado{ get; set; }

        public decimal precio;

        [MaxLength(100, ErrorMessage = "El campo observaciones debe tener maximo 100 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo observaciones no debe tener menos de 5 caracteres")]
        public string observaciones { get; set; } = null!;

    }
}