using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Agencia
    {
        public int IdAgencia { get; set; }

        public int IdBanco { get; set; }  // Clave foránea
        public Banco Banco { get; set; }  // Propiedad de navegación

        [MaxLength(255,ErrorMessage ="El campo agencia debe tener maximo 255 caracteres ")]
        [MinLength(5,ErrorMessage ="El campo agencia no debe tener menos de 5 caracteres")]
        public string NombreAgencia { get; set; } = null!;

        [MaxLength(255, ErrorMessage = "El campo codigo_agencia debe tener maximo 255 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo codigo_agencia no debe tener menos de 5 caracteres")]
        public string CodigoAgencia { get; set; } = null!;
    }
}
