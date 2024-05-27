using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblParamRangosNota
{
    public int? IdRangoNotas { get; set; }

    public int? RangoInicial { get; set; }

    public int? RangoFinal { get; set; }

    public string? Observaciones { get; set; }

    public int IdSequencia { get; set; }
}
