using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblHistoricaCalificaciones2x2
{
    public int? IdAlumno { get; set; }

    public string? Grado { get; set; }

    public string? Seccion { get; set; }

    public int? Nota1 { get; set; }

    public int? Nota2 { get; set; }

    public string? Asignatura { get; set; }

    public int? Promedio { get; set; }

    public int? IdSemestre { get; set; }

    public int? AsignaturaRetrasada { get; set; }

    public int? Anio { get; set; }

    public int? IdCatedratico { get; set; }
}
