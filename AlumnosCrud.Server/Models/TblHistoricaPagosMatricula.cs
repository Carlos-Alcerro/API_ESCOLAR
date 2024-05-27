using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblHistoricaPagosMatricula
{
    public int? IdPago { get; set; }

    public int? IdGrado { get; set; }

    public string? Grado { get; set; }

    public int? NumeroPagos { get; set; }

    public decimal? PrecioMatricula { get; set; }

    public decimal? PrecioSeguro { get; set; }

    public decimal? PagoMensualidad { get; set; }

    public decimal? PagoGastosGraduacion { get; set; }

    public decimal? OtrosGastos { get; set; }

    public string? Observaciones { get; set; }

    public int? Anio { get; set; }
}
