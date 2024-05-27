using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblAlumnosXSeccion
{
    public int? IdGrado { get; set; }

    public int? IdSeccion { get; set; }

    public int? IdAlumno { get; set; }
}
