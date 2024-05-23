using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Agencia
    {
        public int id_conducta { get; set; }
        public int id_alumno { get; set; }
        public int id_asignatura { get; set; }
        public int id_sequencia { get; set; }
        public int id_grado { get; set; }
    }
}