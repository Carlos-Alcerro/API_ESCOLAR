using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblJornada
{
    public int? IdJornada { get; set; }

    public string? Jornada { get; set; }

    public int IdSequencia { get; set; }
}
