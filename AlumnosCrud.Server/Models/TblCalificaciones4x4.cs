using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblCalificaciones4x4
{
    public int? IdAlumno { get; set; }

    public int? Nota1 { get; set; }

    public int? Nota2 { get; set; }

    public int? Nota3 { get; set; }

    public int? Nota4 { get; set; }

    public int? IdAsignatura { get; set; }

    public int? Promedio { get; set; }

    public int? AsignaturaRetrasada { get; set; }
}
