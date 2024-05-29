using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Interes
    {
        [Key]
        public int IdInteres { get; set; }
        public int IdGrado { get; set; }
        public int IdSequencia{ get; set; }
        
        [MaxLength(20, ErrorMessage = "El campo DescripcionInteres debe tener maximo 20 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo DescripcionInteres no debe tener menos de 5 caracteres")]
        public string DescripcionInteres { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo PorcentajeInteres debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo PorcentajeInteres no debe tener menos de 5 caracteres")]
        public string PorcentajeInteres { get; set; } = null!;

    }
}
