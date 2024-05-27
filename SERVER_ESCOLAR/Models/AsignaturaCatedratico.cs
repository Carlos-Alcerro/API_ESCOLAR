using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class AsignaturaCatedratico
    {
        public int id_grado { get; set; }
        public int id_seccion { get; set; }
        public int id_colaborador { get; set; }

        public int asignatura;
    }
}