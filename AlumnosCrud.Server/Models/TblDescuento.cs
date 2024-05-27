using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblDescuento
{
    public int? IdDescuento { get; set; }

    public string? DescripcionDescuento { get; set; }

    public int IdSequencia { get; set; }

    public int? PorcentajeDescuento { get; set; }
}
