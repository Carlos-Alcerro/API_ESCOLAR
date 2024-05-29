using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class AsignaturaCatedratico
    {


        [ForeignKey("Asignatura")]
        public int? IdAsignatura { get; set; }
        public Asignatura Asignatura { get; set; }

        [ForeignKey("Colaborador")]
        public int? IdColaborador { get; set; }
        public Colaborador Colaborador { get; set; }


        [ForeignKey("Grado")]
        public int? IdGrado { get; set; }
        public Grado Grado { get; set; }

        [ForeignKey("Seccion")]
        public int? IdSeccion { get; set; }
        public Seccion Seccion { get; set; }
    }
}