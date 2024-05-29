using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Grado
    {
        [Key]
        public int IdGrado { get; set; }
        public int IdSequencia { get; set; }

        [MaxLength(50, ErrorMessage = "El campo NombreColonia debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo NombreColonia no debe tener menos de 5 caracteres")]
        public string NombreGrado { get; set; } = null!;

        public ICollection<Matricula> Matriculas { get; } = new List<Matricula>();

    }
}
