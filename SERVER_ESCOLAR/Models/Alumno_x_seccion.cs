using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Alumno_x_seccion
    {
        public int id_seccion { get; set; }
        public int id_alumno { get; set; }
        public int id_grado { get; set; }
    }
}