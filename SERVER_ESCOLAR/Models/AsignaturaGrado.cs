using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class AsignaturaGrado
    {

        [ForeignKey("IdAsignatura")]
        public int? IdAsignatura { get; set; }
        public Asignatura Asignatura { get; set; }

        [ForeignKey("IdGrado")]
        public int? IdGrado { get; set; }
        public Grado Grado { get; set; 

    }
}