using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace SERVER_ESCOLAR.Models
{
    public class Alumno_x_transporte
    {
        public int id_transporte_entrada { get; set; }
        public int id_transporte_salida { get; set; }
        public int id_alumno { get; set; }

        public decimal precio;
    }
}