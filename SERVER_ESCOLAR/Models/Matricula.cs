using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Matriculas
    {
        public int IdMatricula { get; set; }
        public int IdAlumno { get; set; }
        public int IdGrado { get; set; }
        public int IdSeccion { get; set; }
        public int IdJornada { get; set; }
        public int Matricula { get; set; }
        public int PreMatricula { get; set; }
        public int IdBanco { get; set; }
        public int IdCodigoAgencia { get; set; }
        public int IdTipoMatricula { get; set; }
        public int MatriculaCondicionada { get; set; }
        public int TipoCondicionada { get; set; }
        public int IdDescuentoMensualidad { get; set; }
        public int IdDescuentoMatricula { get; set; }
        public int IdDescuentoTransporte { get; set; }
        public int UtilizaTransporte { get; set; }
        public int Retirado{ get; set; }

        public DateTime FechaMatricula { get; set; }
     
        [MaxLength(80, ErrorMessage = "El campo NombreAlumno debe tener maximo 80 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo NombreAlumnono debe tener menos de 5 caracteres")]
        public string NombreAlumno{ get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo NumeroCuenta debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo NumeroCuenta debe tener menos de 5 caracteres")]
        public string IdNumeroCuenta { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo IdAgencia debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo IdAgencia debe tener menos de 5 caracteres")]
        public string IdAgencia { get; set; } = null!;

        [MaxLength(60, ErrorMessage = "El campo TipoPago debe tener maximo 60 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo TipoPago debe tener menos de 5 caracteres")]
        public string TipoPago { get; set; } = null!;

        [MaxLength(70, ErrorMessage = "El campo MatriculadoPor debe tener maximo 70 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo MatriculadoPor debe tener menos de 5 caracteres")]
        public string MatriculadoPor{ get; set; } = null!;
        
        [MaxLength(30, ErrorMessage = "El campo NumeroIdentidad debe tener maximo 30 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo NumeroIdentidad debe tener menos de 5 caracteres")]
        public string NumeroIdentidad{ get; set; } = null!;

        [MaxLength(30, ErrorMessage = "El campo TipoIngreso debe tener maximo 30 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo TipoIngreso debe tener menos de 5 caracteres")]
        public string TipoIngreso { get; set; } = null!;
        public int IdSequencia { get; set; }
    }
}
