using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblColaboradore
{
    public string? PrimerNombre { get; set; }

    public string? SegundoNombre { get; set; }

    public string? PrimerApellido { get; set; }

    public string? SegundoApellido { get; set; }

    public string? Genero { get; set; }

    public string? LugarNacimiento { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? NumeroIdentidad { get; set; }

    public int? TipoColaborador { get; set; }

    public int Id { get; set; }
}
