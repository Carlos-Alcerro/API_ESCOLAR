using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblAsignaturasCatedratico
{
    public int? IdGrado { get; set; }

    public int? IdSeccion { get; set; }

    public int? IdColaborador { get; set; }

    public int? IdAsignatura { get; set; }
}
