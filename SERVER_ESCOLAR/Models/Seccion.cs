using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Seccion
    {
        public int IdSeccion { get; set; }

        [MaxLength(50, ErrorMessage = "El campo DescpSeccion debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo DescpSeccion debe tener menos de 5 caracteres")]
        public string DescpSeccion{ get; set; } = null!;
        public int IdSequencia { get; set; }
        public int IdGrado{ get; set; }

    }
}
