using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblPagosXAlumno
{
    public int? IdPago { get; set; }

    public int? IdAlumno { get; set; }

    public DateOnly? FechaVencimiento { get; set; }

    public int? IdTipoPago { get; set; }

    public decimal? TotalAPagar { get; set; }
}
