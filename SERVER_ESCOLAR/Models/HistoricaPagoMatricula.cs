using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class HistoricaPagoMatricula
    {
        public int IdPago { get; set; }
        public int IdGrado{ get; set; }
        public int NumeroPagos { get; set; }
        public int Anio{ get; set; }
        public decimal PrecioMatricula { get; set; }
        public decimal PrecioSeguro { get; set; }
        public decimal PagoMensualidad{ get; set; }
        public decimal PagoGastosGraduacion{ get; set; }
        public decimal OtrosGastos{ get; set; }

        [MaxLength(20, ErrorMessage = "El campo Grado debe tener maximo 20 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo Grado no debe tener menos de 5 caracteres")]
        public string Grado{ get; set; } = null!;
    
        [MaxLength(30, ErrorMessage = "El campo Observaciones debe tener maximo 30 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo Observaciones no debe tener menos de 5 caracteres")]
        public string Observaciones { get; set; } = null!;


    }
}
