using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class PagoAlumnoRealizado
    {
        public int Id{ get; set; }
        public int IdPago { get; set; }
        public int IdAlumno { get; set; }
        public DateTime Fecha{ get; set; }
        public decimal Recargo { get; set; }
        public decimal TotalPagado { get; set; }
        public int IdTipoPago { get; set; }
        public int IdBanco{ get; set; }


        [MaxLength(20, ErrorMessage = "El campo MetodoPago debe tener maximo 20 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo MetodoPago debe tener menos de 5 caracteres")]
        public string MetodoPago { get; set; } = null!;

        [MaxLength(20, ErrorMessage = "El campo NumeroCuenta debe tener maximo 20 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo NumeroCuenta debe tener menos de 5 caracteres")]
        public string NumeroCuenta { get; set; } = null!;

        [MaxLength(20, ErrorMessage = "El campo Agencia debe tener maximo 20 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo Agencia debe tener menos de 5 caracteres")]
        public string Agencia { get; set; } = null!;
    }
}
