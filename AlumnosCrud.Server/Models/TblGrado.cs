using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblGrado
{
    public int? IdGrado { get; set; }

    public string? Grado { get; set; }

    public int IdSequencia { get; set; }
}
