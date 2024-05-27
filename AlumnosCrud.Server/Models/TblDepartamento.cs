using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblDepartamento
{
    public int? IdDepto { get; set; }

    public string? Depto { get; set; }

    public int IdSequencia { get; set; }
}
