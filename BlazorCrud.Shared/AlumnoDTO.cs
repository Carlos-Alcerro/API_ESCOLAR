using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace BlazorCrud.Shared
{
    public class AlumnoDTO
    {

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "El campo{0} es requerido.")]
        public int id { get; set; }

        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? primer_nombre { get; set; }

        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? segundo_nombre { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? primer_apellido { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? segundo_apellido { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? genero { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? lugar_nacimiento { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public DateTime? fecha_nacimiento { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? direccion { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? telefono { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? region { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? escuela_procedencia { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? anio_ingreso { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? numero_identidad { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? tiene_hermanos { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "El campo{0} es requerido.")]
        public int? numero_miembros { get; set; }

        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? nombre_madre { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? profesion_madre { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? lugar_trabajo_madre { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? telefono_madre { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? celular_madre { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? nombre_padre { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? profesion_padre { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? lugar_trabajo_padre { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? telefono_padre { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? celular_padre { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? ausencia_nombre1 { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? ausencia_nombre2 { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? ausencia_nombre3 { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? parentesco1 { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? parentesco2 { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? parentesco3 { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? telefono_ausencia1 { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? telefono_ausencia2 { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? telefono_ausencia3 { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? estado_civil_padres { get; set; }
        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? con_quien_vive_alumno { get; set; }

        [Required(ErrorMessage = "El campo{0} es requerido.")]
        public string? observaciones { get; set; }

    }
}
