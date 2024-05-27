using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblIntere
{
    public int? IdInteres { get; set; }

    public int? IdGrado { get; set; }

    public string? DescripcionInteres { get; set; }

    public string? PorcentajeInteres { get; set; }

    public int IdSequencia { get; set; }
}
