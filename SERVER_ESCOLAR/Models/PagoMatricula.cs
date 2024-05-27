using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class PagoMatricula
    {
        public int IdPago { get; set; }
        public int IdGrado { get; set; }
        public int NumeroPagos{ get; set; }
        public decimal PrecioMatricula { get; set; }
        public decimal PrecioSeguro { get; set; }
        public decimal PagoMensualidad{ get; set; }
        public decimal PagoGastosGraduacion{ get; set; }
        public decimal OtrosGastos { get; set; }

        [MaxLength(50, ErrorMessage = "El campo Observacion debe tener maximo 80 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo Observacion debe tener menos de 5 caracteres")]
        public string Observacion{ get; set; } = null!;
        public int IdSequencia { get; set; }
    }
}
