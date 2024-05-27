using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class AlumnoConducta
    {
        public int IdAlumno{get; set;}
        public int IdAsignatura {get; set;}
        public int IdConducta {get; set;}
        public int IdSequencia {get; set;}
        public int IdGrado {get; set;}

    }
}
