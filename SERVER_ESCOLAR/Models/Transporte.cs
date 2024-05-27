using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Transporte

    {
        public int IdTransporte { get; set; }

        [MaxLength(50, ErrorMessage = "El campo CodigoTransporte debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo CodigoTransporte debe tener menos de 5 caracteres")]
        public string? CodigoTransporte{ get; set; } 

        [MaxLength(80, ErrorMessage = "El campo CodigoTransporte debe tener maximo 80 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo CodigoTransporte debe tener menos de 5 caracteres")]
        public string? Ruta { get; set; }
        public int IdSequencia { get; set; }

    }
}
