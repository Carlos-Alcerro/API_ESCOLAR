using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class AlumnoConducta
    {
        [ForeignKey("Alumno")]
        public int? IdAlumno { get; set; }
        public Alumno Alumno { get; set; }

        [ForeignKey("Conducta")]
        public int? IdConducta { get; set; }
        public EstadoConducta Conducta{ get; set; }

        [ForeignKey("Asignatura")]
        public int? IdAsignatura { get; set; }
        public Asignatura Asignatura { get; set; }

        [ForeignKey("Grado")]
        public int? IdGrado { get; set; }
        public Asignatura Grado { get; set; }

        public int IdSequencia {get; set;}

    }
}
