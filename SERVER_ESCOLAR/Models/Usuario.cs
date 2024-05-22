using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [MaxLength(255,ErrorMessage ="El campo nombres debe tener maxiomo 255 caracteres ")]
        [MinLength(5,ErrorMessage ="El campo nombres no debe tener menos de 5 caracteres")]
        public string Nombres { get; set; } = null!;

        [MaxLength(255, ErrorMessage = "El campo apellidos debe tener maxiomo 255 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo apellidos no debe tener menos de 5 caracteres")]
        public string Apellidos { get; set; } = null!;

        [MaxLength(100,ErrorMessage ="El campo contrasena no debe tener mas de 100 caracteres")]
        [MinLength(8,ErrorMessage ="El campo contrasena no debe tener menos de 8 caracteres")]
        [DataType(DataType.Password)]
        public string Contrasena { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo correo no debe tener mas de 50 caracteres")]
        [MinLength(5, ErrorMessage = "El campo correo no debe tener menos de 5 caracteres")]
        public string Correo { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo ciudad no debe tener mas de 50 caracteres")]
        [MinLength(5, ErrorMessage = "El campo ciudad no debe tener menos de 5 caracteres")]
        public string Ciudad { get; set; } = null!;

        [DataType(DataType.MultilineText)]
        [MaxLength(500, ErrorMessage = "El campo direccion debe tener maxiomo 500 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo direccion no debe tener menos de 5 caracteres")]
        public string Direccion { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo rol no debe tener más de 50 caracteres")]
        public string Rol { get; set; } = "Profesor";

    }
}
