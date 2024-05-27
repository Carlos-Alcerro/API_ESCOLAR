using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblAlumnosConductum
{
    public int? IdAlumno { get; set; }

    public int? IdAsignatura { get; set; }

    public int? IdConducta { get; set; }

    public int IdSequencia { get; set; }

    public int? IdGrado { get; set; }
}
