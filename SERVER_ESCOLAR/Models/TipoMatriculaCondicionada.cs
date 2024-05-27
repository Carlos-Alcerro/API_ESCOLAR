using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class TipoMatriculaCondicionada
    {
        public int IdTipoMatriculaCondicionada { get; set; }

        [MaxLength(50, ErrorMessage = "El campo DescpTipoMatriculaCondicionada debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo DescpTipoMatriculaCondicionada debe tener menos de 5 caracteres")]
        public string DescpTipoMatriculaCondicionada { get; set; } = null!;
        public int IdSequencia { get; set; }

    }
}
