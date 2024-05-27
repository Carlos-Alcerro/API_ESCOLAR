using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblAlumnosHi
{
    public int? Id { get; set; }

    public string? PrimerNombre { get; set; }

    public string? SegundoNombre { get; set; }

    public string? PrimerApellido { get; set; }

    public string? SegundoApellido { get; set; }

    public string? Genero { get; set; }

    public string? LugarNacimiento { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? Region { get; set; }

    public string? EscuelaProcedencia { get; set; }

    public string? AnioIngreso { get; set; }

    public string? NumeroIdentidad { get; set; }

    public string? TieneHermanos { get; set; }

    public int? NumeroMiembros { get; set; }

    public string? NombreMadre { get; set; }

    public string? ProfesionMadre { get; set; }

    public string? LugarTrabajoMadre { get; set; }

    public string? TelefonoMadre { get; set; }

    public string? CelularMadre { get; set; }

    public string? NombrePadre { get; set; }

    public string? ProfesionPadre { get; set; }

    public string? LugarTrabajoPadre { get; set; }

    public string? TelefonoPadre { get; set; }

    public string? CelularPadre { get; set; }

    public string? AusenciaNombre1 { get; set; }

    public string? AusenciaNombre2 { get; set; }

    public string? AusenciaNombre3 { get; set; }

    public string? Parentesco1 { get; set; }

    public string? Parentesco2 { get; set; }

    public string? Parentesco3 { get; set; }

    public string? TelefonoAusencia1 { get; set; }

    public string? TelefonoAusencia2 { get; set; }

    public string? TelefonoAusencia3 { get; set; }

    public string? EstadoCivilPadres { get; set; }

    public string? ConQuienViveAlumno { get; set; }

    public string? Observaciones { get; set; }

    public int IdSequencia { get; set; }
}
