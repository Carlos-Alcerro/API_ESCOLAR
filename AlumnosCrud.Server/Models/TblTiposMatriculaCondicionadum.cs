using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblTiposMatriculaCondicionadum
{
    public int? IdMatriculaCondicionada { get; set; }

    public string? MatriculaCondicionada { get; set; }

    public int IdSequencia { get; set; }
}
