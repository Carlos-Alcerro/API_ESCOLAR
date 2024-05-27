using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblColonia
{
    public int? IdColonia { get; set; }

    public int? IdMunicipio { get; set; }

    public string? Colonia { get; set; }

    public int IdSequencia { get; set; }
}
