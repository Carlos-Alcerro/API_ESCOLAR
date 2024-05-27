using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblBanco
{
    public int? IdBanco { get; set; }

    public string? Banco { get; set; }

    public string? NumeroCuenta { get; set; }

    public int IdSequencia { get; set; }
}
