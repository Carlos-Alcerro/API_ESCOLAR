using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Descuento
    {
        [Key]
        public int IdDescuento { get; set; }
        public int IdSequencia { get; set; }

        [MaxLength(50, ErrorMessage = "El campo TipoDescuento debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo TipoDescuento no debe tener menos de 5 caracteres")]
        public string TipoDescuento { get; set; } = null!;

        public int PorcentajeDescuento { get; set; }
        public ICollection<MatriculaDescuento> MatriculaDescuento { get; set; }

    }
}
