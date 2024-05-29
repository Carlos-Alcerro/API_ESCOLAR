using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class TipoMatricula
    {
        [Key]
        public int IdTipoMatricula { get; set; }

        [MaxLength(50, ErrorMessage = "El campo DescpTipoMatricula debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo DescpTipoMatricula debe tener menos de 5 caracteres")]
        public string DescpTipoMatricula{ get; set; } = null!;
        public int IdSequencia { get; set; }

        public ICollection<Matricula> Matriculas { get; } = new List<Matricula>();

    }
}
