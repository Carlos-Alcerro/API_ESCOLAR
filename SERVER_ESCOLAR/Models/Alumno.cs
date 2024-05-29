using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Alumno
    {
        [Key]
        public int IdAlumno { get; set; }

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

        [MaxLength(20, ErrorMessage = "El campo region debe tener maximo 20 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo region no debe tener menos de 5 caracteres")]
        public string Region { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo escuela_procedencia debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo escuela_procedencia no debe tener menos de 5 caracteres")]
        public string EscuelaProcedencia { get; set; } = null!;

        [MaxLength(10, ErrorMessage = "El campo anio_ingreso debe tener maximo 10 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo anio_ingreso no debe tener menos de 5 caracteres")]
        public string AnioIngreso { get; set; } = null!;

        [MaxLength(15, ErrorMessage = "El campo numero_identidad debe tener maximo 15 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo numero_identidad no debe tener menos de 5 caracteres")]
        public string NumeroIdentidad { get; set; } = null!;

        [MaxLength(3, ErrorMessage = "El campo tiene_hermanos debe tener maximo 3 caracteres ")]
        [MinLength(2, ErrorMessage = "El campo tiene_hermanos no debe tener menos de 2 caracteres")]
        public string TieneHermanos { get; set; } = null!;
        public int numero_miembros { get; set; }

        [MaxLength(50, ErrorMessage = "El campo nombre_madre debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo nombre_madre no debe tener menos de 5 caracteres")]
        public string NombreMadre { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo lugar_trabajo_madre debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo lugar_trabajo_madre no debe tener menos de 5 caracteres")]
        public string LugarTrabajoMadre { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo profesion_madre debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo profesion_madre no debe tener menos de 5 caracteres")]
        public string ProfesionMadre { get; set; } = null!;

        [MaxLength(12, ErrorMessage = "El campo telefono_madre debe tener maximo 12 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo telefono_madre no debe tener menos de 5 caracteres")]
        public string TelefonoMadre { get; set; } = null!;

        [MaxLength(12, ErrorMessage = "El campo celular_madre debe tener maximo 12 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo celular_madre no debe tener menos de 5 caracteres")]
        public string CelularMadre { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo nombre_padre debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo nombre_padre no debe tener menos de 5 caracteres")]
        public string NombrePadre { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo lugar_trabajo_padre debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo lugar_trabajo_padre no debe tener menos de 5 caracteres")]
        public string LugarTrabajoPadre { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo profesion_padre debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo profesion_padre no debe tener menos de 5 caracteres")]
        public string ProfesionPadre { get; set; } = null!;

        [MaxLength(12, ErrorMessage = "El campo telefono_padre debe tener maximo 12 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo telefono_padre no debe tener menos de 5 caracteres")]
        public string TelefonoPadre { get; set; } = null!;

        [MaxLength(12, ErrorMessage = "El campo celular_padre debe tener maximo 12 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo celular_padre no debe tener menos de 5 caracteres")]
        public string CelularPadre { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo ausencia_nombre1 debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo ausencia_nombre1 no debe tener menos de 5 caracteres")]
        public string AusenciaNombre1 { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo ausencia_nombre2 debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo ausencia_nombre2 no debe tener menos de 5 caracteres")]
        public string AusenciaNombre2 { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo ausencia_nombre3 debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo ausencia_nombre3 no debe tener menos de 5 caracteres")]
        public string AusenciaNombre3 { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo parentesco1 debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo parentesco1 no debe tener menos de 5 caracteres")]
        public string Parentesco1 { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo parentesco2 debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo parentesco2 no debe tener menos de 5 caracteres")]
        public string Parentesco2 { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo parentesco3 debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo parentesco3 no debe tener menos de 5 caracteres")]
        public string Parentesco3 { get; set; } = null!;

        [MaxLength(12, ErrorMessage = "El campo telefono_ausencia1 debe tener maximo 12 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo telefono_ausencia1 no debe tener menos de 5 caracteres")]
        public string TelefonoAusencia1 { get; set; } = null!;

        [MaxLength(12, ErrorMessage = "El campo telefono_ausencia2 debe tener maximo 12 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo telefono_ausencia2 no debe tener menos de 5 caracteres")]
        public string TelefonoAusencia2 { get; set; } = null!;

        [MaxLength(12, ErrorMessage = "El campo telefono_ausencia3 debe tener maximo 12 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo telefono_ausencia3 no debe tener menos de 5 caracteres")]
        public string TelefonoAusencia3 { get; set; } = null!;

        [MaxLength(20, ErrorMessage = "El campo estado_civil_padres debe tener maximo 20 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo estado_civil_padres no debe tener menos de 5 caracteres")]
        public string EstadoCivilPadres { get; set; } = null!;

        [MaxLength(30, ErrorMessage = "El campo con_quien_vive_alumno debe tener maximo 30 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo con_quien_vive_alumno no debe tener menos de 5 caracteres")]
        public string ConQuienViveAlumno { get; set; } = null!;

        [MaxLength(30, ErrorMessage = "El campo observaciones debe tener maximo 80 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo observaciones no debe tener menos de 5 caracteres")]
        public string Observaciones { get; set; } = null!;

        public int IdSequencia { get; set; }

        public ICollection<Matricula> Matriculas { get; } = new List<Matricula>();

        public ICollection<AlumnoConducta> AlumnoConducta { get; set; }


    }
}
