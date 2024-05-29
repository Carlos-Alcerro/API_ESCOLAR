using System.ComponentModel.DataAnnotations;

namespace SERVER_ESCOLAR.Models
{

    public class Asignatura
    {
        [Key]
        public int IdAsignatura { get; set; }

        [MaxLength(50, ErrorMessage = "El campo nombre_asignatura debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo nombre_asignatura no debe tener menos de 5 caracteres")]
        public string DescpAsignatura{ get; set; } = null!;

        public ICollection<AsignaturaGrado> AsignaturaGrado { get; set; }

        public ICollection<AlumnoConducta> AlumnoConductas { get; set; }


    }
}
