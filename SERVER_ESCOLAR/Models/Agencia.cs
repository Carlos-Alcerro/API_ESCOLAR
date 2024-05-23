using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Alumno_conducta
    {
        public int Id { get; set; }
        public int IdBanco { get; set; }
        public int IdSequencia { get; set; }

        [MaxLength(255,ErrorMessage ="El campo agencia debe tener maximo 255 caracteres ")]
        [MinLength(5,ErrorMessage ="El campo agencia no debe tener menos de 5 caracteres")]
        public string Agencia { get; set; } = null!;

        [MaxLength(255, ErrorMessage = "El campo codigo_agencia debe tener maximo 255 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo codigo_agencia no debe tener menos de 5 caracteres")]
        public string CodigoAgencia { get; set; } = null!;
    }
}
