using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblMatricula
{
    public int? IdMatricula { get; set; }

    public int IdAlumno { get; set; }

    public string? NombreAlumno { get; set; }

    public int? IdGrado { get; set; }

    public int? IdSeccion { get; set; }

    public int? IdJornada { get; set; }

    public int? Matricula { get; set; }

    public int? PreMatricula { get; set; }

    public DateTime? FechaMatricula { get; set; }

    public int? IdBanco { get; set; }

    public string? IdNumeroCuenta { get; set; }

    public int? IdCodigoAgencia { get; set; }

    public string? IdAgencia { get; set; }

    public int? IdTipoMatricula { get; set; }

    public int? MatriculaCondicionada { get; set; }

    public int? TipoCondicionada { get; set; }

    public string? TipoPago { get; set; }

    public int? IdDescuentoMensualidad { get; set; }

    public int? IdDescuentoMatricula { get; set; }

    public int? IdDescuentoTransporte { get; set; }

    public string? MatriculadoPor { get; set; }

    public string? NumeroIdentidad { get; set; }

    public string? TipoIngreso { get; set; }

    public int? UtilizaTransporte { get; set; }

    public int IdSequencia { get; set; }

    public int? Retirado { get; set; }
}
