using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblCalificaciones2x2
{
    public int? IdAlumno { get; set; }

    public int? Nota1 { get; set; }

    public int? Nota2 { get; set; }

    public int? IdAsignatura { get; set; }

    public int? Promedio { get; set; }

    public int? IdSemestre { get; set; }

    public int? AsignaturaRetrasada { get; set; }
}
