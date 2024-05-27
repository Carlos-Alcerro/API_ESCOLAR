using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblMunicipio
{
    public int? IdMunicipio { get; set; }

    public int? IdDepto { get; set; }

    public string? Municipio { get; set; }

    public int IdSequencia { get; set; }
}
