using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class ParamRangoNota
    {
        [Key]
        public int IdRangoNota{ get; set; }
        public int RangoInicial { get; set; }
        public int RangoFinal{ get; set; }
        public int IdSequencia{ get; set; }

        [MaxLength(50, ErrorMessage = "El campo Observaciones debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo Observaciones debe tener menos de 5 caracteres")]
        public string Observaciones { get; set; } = null!;

}
}
