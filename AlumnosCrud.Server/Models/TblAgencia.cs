using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblAgencia
{
    public int? IdAgencia { get; set; }

    public string? Agencia { get; set; }

    public string? CodigoAgencia { get; set; }

    public int? IdBanco { get; set; }

    public int IdSequencia { get; set; }
}
