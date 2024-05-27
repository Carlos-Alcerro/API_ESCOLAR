using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblTransporte
{
    public int? IdTransporte { get; set; }

    public string? CodigoTransporte { get; set; }

    public string? Ruta { get; set; }

    public int IdSequencia { get; set; }
}
