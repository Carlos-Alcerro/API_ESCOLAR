using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Matricula
    {
        [Key]
        public int IdMatricula { get; set; }
        public int Matriculas { get; set; }
        public int PreMatricula { get; set; }
        public int IdCodigoAgencia { get; set; }
        public int MatriculaCondicionada { get; set; }
        public int UtilizaTransporte { get; set; }
        public int Retirado { get; set; }

        public DateTime FechaMatricula { get; set; }

        [MaxLength(80, ErrorMessage = "El campo NombreAlumno debe tener maximo 80 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo NombreAlumnono debe tener menos de 5 caracteres")]
        public string NombreAlumno { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo NumeroCuenta debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo NumeroCuenta debe tener menos de 5 caracteres")]
        public string IdNumeroCuenta { get; set; } = null!;

        [MaxLength(60, ErrorMessage = "El campo TipoPago debe tener maximo 60 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo TipoPago debe tener menos de 5 caracteres")]
        public string TipoPago { get; set; } = null!;

        [MaxLength(70, ErrorMessage = "El campo MatriculadoPor debe tener maximo 70 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo MatriculadoPor debe tener menos de 5 caracteres")]
        public string MatriculadoPor { get; set; } = null!;

        [MaxLength(30, ErrorMessage = "El campo NumeroIdentidad debe tener maximo 30 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo NumeroIdentidad debe tener menos de 5 caracteres")]
        public string NumeroIdentidad { get; set; } = null!;

        [MaxLength(30, ErrorMessage = "El campo TipoIngreso debe tener maximo 30 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo TipoIngreso debe tener menos de 5 caracteres")]
        public string TipoIngreso { get; set; } = null!;
        public int IdSequencia { get; set; }

        public ICollection<MatriculaDescuento> MatriculaDescuento { get; set; }

        [ForeignKey("Grado")]
        public int? IdGrado { get; set; }
        public Grado? Grado { get; set; } = null!;

        [ForeignKey("Seccion")]
        public int? IdSeccion { get; set; }
        public Seccion? Seccion { get; set; } = null!;

        [ForeignKey("Jornada")]
        public int? IdJornada { get; set; }
        public Jornada? Jornada { get; set; } = null!;
        
        [ForeignKey("Banco")]
        public int? IdBanco { get; set; }
        public Banco? Banco { get; set; } = null!;

        [ForeignKey("Agencia")]
        public int? IdAgencia { get; set; }
        public Agencia? Agencia { get; set; } = null!;

        [ForeignKey("Alumno")]
        public int? IdAlumno { get; set; }
        public Agencia? Alumno { get; set; } = null!;

        [ForeignKey("TipoMatricula")]
        public int? IdTipoMatricula { get; set; }
        public TipoMatricula? TipoMatricula { get; set; } = null!;

        [ForeignKey("TipoCondicionada")]
        public int? IdTipoCondicionada { get; set; }
        public TipoMatriculaCondicionada? TipoMatriculaCondicionada { get; set; } = null!;
    }
}
