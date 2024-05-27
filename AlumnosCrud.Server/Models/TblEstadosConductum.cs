using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblEstadosConductum
{
    public int? IdEstadoConducta { get; set; }

    public string? DescripcionConducta { get; set; }

    public int IdSequencia { get; set; }
}
