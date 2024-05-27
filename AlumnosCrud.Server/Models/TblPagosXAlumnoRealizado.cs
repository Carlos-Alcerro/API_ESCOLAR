using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblPagosXAlumnoRealizado
{
    public int Id { get; set; }

    public int? IdAlumno { get; set; }

    public int? IdPago { get; set; }

    public int? IdTipoPago { get; set; }

    public decimal? Recargo { get; set; }

    public decimal? TotalPagado { get; set; }

    public DateTime? Fecha { get; set; }

    public string? MetodoPago { get; set; }

    public int? IdBanco { get; set; }

    public string? NumeroCuenta { get; set; }

    public string? Agencia { get; set; }
}
