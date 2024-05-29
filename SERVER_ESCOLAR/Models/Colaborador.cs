using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Colaborador
    {
        [Key]
        public int IdColaborador { get; set; }

        public DateTime FechaNacimiento;

        [MaxLength(100, ErrorMessage = "El campo nombres debe tener maximo 100 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo nombres no debe tener menos de 5 caracteres")]
        public string Nombres { get; set; } = null!;

        [MaxLength(100, ErrorMessage = "El campo apellidos debe tener maximo 100 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo apellidos no debe tener menos de 5 caracteres")]
        public string Apellidos { get; set; } = null!;

        [MaxLength(15, ErrorMessage = "El campo genero debe tener maximo 15 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo genero no debe tener menos de 5 caracteres")]
        public string Genero { get; set; } = null!;

        [MaxLength(70, ErrorMessage = "El campo lugar_nacimiento debe tener maximo 70 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo lugar_nacimiento no debe tener menos de 5 caracteres")]
        public string LugarNacimiento { get; set; } = null!;

        [MaxLength(80, ErrorMessage = "El campo direccion debe tener maximo 80 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo direccion no debe tener menos de 5 caracteres")]
        public string Direccion { get; set; } = null!;

        [MaxLength(12, ErrorMessage = "El campo telefono debe tener maximo 12 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo telefono no debe tener menos de 5 caracteres")]
        public string Telefono { get; set; } = null!;

        [MaxLength(15, ErrorMessage = "El campo numero_identidad debe tener maximo 15 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo numero_identidad no debe tener menos de 5 caracteres")]
        public string NumeroIdentidad { get; set; } = null!;
        public int IdSequencia { get; set; }

        public int TipoColaborador { get; set; }
    }
}
