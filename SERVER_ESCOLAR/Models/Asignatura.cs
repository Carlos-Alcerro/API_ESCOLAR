using System.ComponentModel.DataAnnotations;

namespace SERVER_ESCOLAR.Models
{

    public class Asignatura
    {
        public int id_asignatura { get; set; }

        [MaxLength(50, ErrorMessage = "El campo nombre_asignatura debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo nombre_asignatura no debe tener menos de 5 caracteres")]
        public string nombre_asignatura { get; set; } = null!;

      
    }
}
