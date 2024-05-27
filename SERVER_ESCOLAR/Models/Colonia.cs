using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Colonia
    {
        public int IdColonia { get; set; }
        public int IdMunicipio { get; set; }

        [MaxLength(50, ErrorMessage = "El campo NombreColonia debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo NombreColonia no debe tener menos de 5 caracteres")]
        public string NombreColonia { get; set; } = null!;

        public int IdSequencia { get; set; }
    }
}
