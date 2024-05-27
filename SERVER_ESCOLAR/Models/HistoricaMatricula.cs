using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class HistoricaMatricula
    {
        public int IdMatricula { get; set; }
        public int IdAlumno { get; set; }
        public int IdGrado{ get; set; }
        public int IdSeccion { get; set; }
        public int IdJornada { get; set; }

        public DateTime FechaMatricula;

        public int IdTipoMatricula { get; set; }
        public int MatriculaCondicionada { get; set; }
        public int DescuentoMensualidad{ get; set; }
        public int DescuentoMatricula{ get; set; }
        public int DescuentoTransporte { get; set; }
        public int UtilizaTransporte { get; set; }
        public int Anio{ get; set; }

        [MaxLength(80, ErrorMessage = "El campo NombreAlumno debe tener maximo 80 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo NombreAlumno no debe tener menos de 5 caracteres")]
        public string NombreAlumno { get; set; } = null!;

        [MaxLength(20, ErrorMessage = "El campo Grado debe tener maximo 20 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo Grado no debe tener menos de 5 caracteres")]
        public string Grado{ get; set; } = null!;


        [MaxLength(20,ErrorMessage = "El campo Secion debe tener maximo 20 caracteres ")]
        [MinLength(5,ErrorMessage = "El campo Secion no debe tener menos de 5 caracteres")]
        public string Secion { get; set; } = null!;

        [MaxLength(30, ErrorMessage = "El campo Grado debe tener maximo 30 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo Grado no debe tener menos de 5 caracteres")]
        public string Banco { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo NumeroCuenta debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo NumeroCuenta no debe tener menos de 5 caracteres")]
        public string NumeroCuenta { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo Agencia debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo Agencia no debe tener menos de 5 caracteres")]
        public string Agencia { get; set; } = null!;

        [MaxLength(100, ErrorMessage = "El campo TipoCondicionada debe tener maximo 100 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo TipoCondicionada no debe tener menos de 5 caracteres")]
        public string TipoCondicionada { get; set; } = null!;


        [MaxLength(100, ErrorMessage = "El campo TipoPago debe tener maximo 100 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo TipoPago no debe tener menos de 5 caracteres")]
        public string TipoPago{ get; set; } = null!;
        
        [MaxLength(70, ErrorMessage = "El campo MatriculadoPor debe tener maximo 70 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo MatriculadoPor no debe tener menos de 5 caracteres")]
        public string MatriculadoPor { get; set; } = null!;

        [MaxLength(30, ErrorMessage = "El campo MatriculadoPor debe tener maximo 30 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo MatriculadoPor no debe tener menos de 5 caracteres")]
        public string NumeroIdentidad { get; set; } = null!;

        [MaxLength(30, ErrorMessage = "El campo TipoIngreso debe tener maximo 30 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo TipoIngreso no debe tener menos de 5 caracteres")]
        public string TipoIngreso { get; set; } = null!;


    }
}
