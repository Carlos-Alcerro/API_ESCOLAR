using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Agencia
    {
        public int IdAgencia { get; set; }

        [MaxLength(50, ErrorMessage = "El campo CodigoAgencia debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo CodigoAgencia no debe tener menos de 5 caracteres")]
        public string CodigoAgencia { get; set; } = null!;

        public int IdBanco { get; set; }
        public Banco Banco { get; set; } = null!; // Propiedad de navegación

        public int IdSequencia { get; set; }

        [MaxLength(50, ErrorMessage = "El campo DescpAgencia debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo DescpAgencia no debe tener menos de 5 caracteres")]
        public string DescpAgencia { get; set; } = null!;
    }
}