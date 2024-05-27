using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class PagoAlumno
    {
        public int IdPago { get; set; }
        public int IdAlumno { get; set; }
        public DateTime FechaVencimiento{ get; set; }
        public decimal TotalPagar { get; set; }
        public int TipoPago { get; set; }
    }
}
