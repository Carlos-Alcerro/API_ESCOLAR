using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblAsignaturasRetrasada
{
    public int IdAsignaturaRetrasada { get; set; }

    public int? IdAlumno { get; set; }

    public int? IdAsignatura { get; set; }

    public int? IdGrado { get; set; }

    public string? Estado { get; set; }

    public decimal? Precio { get; set; }
}
