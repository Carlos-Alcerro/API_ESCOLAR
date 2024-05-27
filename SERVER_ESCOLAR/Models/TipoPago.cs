using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class TipoPago
    {
        public int IdTipoPago{ get; set; }

        [MaxLength(25, ErrorMessage = "El campo DescpTipoPago debe tener maximo 25 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo DescpTipoPago debe tener menos de 5 caracteres")]
        public string DescpTipoPago{ get; set; } = null!;

    }
}
