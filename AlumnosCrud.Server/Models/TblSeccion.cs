using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblSeccion
{
    public int? IdSeccion { get; set; }

    public string? Seccion { get; set; }

    public int? IdGrado { get; set; }

    public int IdSequencia { get; set; }
}
