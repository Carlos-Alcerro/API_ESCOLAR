using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class MatriculaDescuento
    {
        [ForeignKey("Descuento")]
        public int? IdDescuento { get; set; }
        public Descuento Descuento { get; set; }

        [ForeignKey("Matricula")]
        public int IdMatricula { get; set; }
        public Matricula Matricula { get; set; }


    }
}
