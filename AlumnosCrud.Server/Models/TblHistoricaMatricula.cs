using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblHistoricaMatricula
{
    public int? IdMatricula { get; set; }

    public int IdAlumno { get; set; }

    public string? NombreAlumno { get; set; }

    public int? IdGrado { get; set; }

    public string? Grado { get; set; }

    public int? IdSeccion { get; set; }

    public string? Seccion { get; set; }

    public int? IdJornada { get; set; }

    public DateTime? FechaMatricula { get; set; }

    public string? Banco { get; set; }

    public string? NumeroCuenta { get; set; }

    public string? Agencia { get; set; }

    public int? IdTipoMatricula { get; set; }

    public int? MatriculaCondicionada { get; set; }

    public string? TipoCondicionada { get; set; }

    public string? TipoPago { get; set; }

    public int? DescuentoMensualidad { get; set; }

    public int? DescuentoMatricula { get; set; }

    public int? DescuentoTransporte { get; set; }

    public string? MatriculadoPor { get; set; }

    public string? NumeroIdentidad { get; set; }

    public string? TipoIngreso { get; set; }

    public int? UtilizaTransporte { get; set; }

    public int? Anio { get; set; }
}
