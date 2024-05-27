using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblTipoMatricula
{
    public int? IdTipoMatricula { get; set; }

    public string? TipoMatricula { get; set; }

    public int IdSequencia { get; set; }
}
