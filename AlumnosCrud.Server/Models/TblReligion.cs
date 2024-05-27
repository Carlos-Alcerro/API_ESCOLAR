using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblReligion
{
    public int? IdReligion { get; set; }

    public string? Religion { get; set; }

    public int IdSequencia { get; set; }
}
