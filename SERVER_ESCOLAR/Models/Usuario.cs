using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [ForeignKey("Rol")]
        public int? IdRol { get; set; }
        public Rol? Rol { get; set; } = null!;
        public int UsuarioBloqueado { get; set; }

        public DateTime FechaNacimiento;

        [MaxLength(255,ErrorMessage ="El campo nombres debe tener maxiomo 255 caracteres ")]
        [MinLength(5,ErrorMessage ="El campo nombres no debe tener menos de 5 caracteres")]
        public string Nombres { get; set; } = null!;

        [MaxLength(255, ErrorMessage = "El campo apellidos debe tener maxiomo 255 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo apellidos no debe tener menos de 5 caracteres")]
        public string Apellidos { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo dni debe tener maxiomo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo dni no debe tener menos de 5 caracteres")]
        public string Dni { get; set; } = null!;

        [MaxLength(100,ErrorMessage ="El campo contrasena no debe tener mas de 100 caracteres")]
        [MinLength(8,ErrorMessage ="El campo contrasena no debe tener menos de 8 caracteres")]
        [DataType(DataType.Password)]
        public string Contrasena { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo correo no debe tener mas de 50 caracteres")]
        [MinLength(5, ErrorMessage = "El campo correo no debe tener menos de 5 caracteres")]
        public string Correo { get; set; } = null!;

        [MaxLength(1, ErrorMessage = "El campo sexo no debe tener mas de 1 caracteres")]
        [MinLength(1, ErrorMessage = "El campo sexo no debe tener menos de 1 caracteres")]
        public string Sexo { get; set; } = null!;

        [DataType(DataType.MultilineText)]
        [MaxLength(100, ErrorMessage = "El campo direccion debe tener maxiomo 100 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo direccion no debe tener menos de 5 caracteres")]
        public string Direccion { get; set; } = null!;

        [DataType(DataType.MultilineText)]
        [MaxLength(9, ErrorMessage = "El campo telefono debe tener maxiomo 9 caracteres ")]
        [MinLength(9, ErrorMessage = "El campo telefono no debe tener menos de 9 caracteres")]
        public string Telefono { get; set; } = null!;


    }
}
