using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Seccion
    {
        [Key]
        public int IdSeccion { get; set; }

        [MaxLength(50, ErrorMessage = "El campo DescpSeccion debe tener maximo 50 caracteres ")]
        [MinLength(5, ErrorMessage = "El campo DescpSeccion debe tener menos de 5 caracteres")]
        public string DescpSeccion{ get; set; } = null!;
        public int IdSequencia { get; set; }


        [ForeignKey("Grado")]
        public int? IdGrado { get; set; }
        public Grado? Grado { get; set; } = null!;

        public ICollection<Matricula> Matriculas { get; } = new List<Matricula>();

        public ICollection<AsignaturaCatedratico> AsignaturaCatedraticos { get; } = new List<AsignaturaCatedratico>();


    }
}
