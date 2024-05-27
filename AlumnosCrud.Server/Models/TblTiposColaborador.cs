using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblTiposColaborador
{
    public int? IdTiposColaborador { get; set; }

    public string? DescripcionColaborador { get; set; }

    public int IdSequencia { get; set; }
}
