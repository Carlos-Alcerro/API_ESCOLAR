using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Banco
    {
        [Key]
        public int IdBanco { get; set; }
        public int IdSequencia { get; set; }

        [MaxLength(50, ErrorMessage = "El campo NombreBanco debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo NombreBanco no debe tener menos de 5 caracteres")]
        public string NombreBanco { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo NumeroCuenta debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo NumeroCuenta no debe tener menos de 5 caracteres")]
        public string NumeroCuenta { get; set; } = null!;

        public ICollection<Agencia> Agencias { get; } = new List<Agencia>();

        public ICollection<Matricula> Matriculas { get; } = new List<Matricula>();

    }
}
