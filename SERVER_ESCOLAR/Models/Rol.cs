using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Rol
    {
        public int IdRol { get; set; }

        [MaxLength(50, ErrorMessage = "El campo DescripcionRol debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo DescripcionRol debe tener menos de 5 caracteres")]
        public string DescripcionRol{ get; set; } = null!;
        public int IdSequencia { get; set; }
    }
}
