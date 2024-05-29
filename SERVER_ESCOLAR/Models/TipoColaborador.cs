using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class TipoColaborador
    {
        [Key]
        public int IdTipoColaborador{ get; set; }

        [MaxLength(50, ErrorMessage = "El campo DescripcionColaborador debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo DescripcionColaborador debe tener menos de 5 caracteres")]
        public string? DescripcionColaborador{ get; set; }

        public int IdSequencia { get; set; }


    }
}
