using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblAlumnosXTransporte
{
    public int? IdTransporteEntrada { get; set; }

    public int? IdTransporteSalida { get; set; }

    public int? IdAlumno { get; set; }

    public decimal? Precio { get; set; }
}
