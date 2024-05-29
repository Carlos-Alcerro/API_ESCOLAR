using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Religion
    {
        [Key]
        public int IdReligion { get; set; }

        [MaxLength(50, ErrorMessage = "El campo NombreReligion debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo NombreReligion debe tener menos de 5 caracteres")]
        public string NombreReligion{ get; set; } = null!;
        public int IdSequencia { get; set; }
    }
}
