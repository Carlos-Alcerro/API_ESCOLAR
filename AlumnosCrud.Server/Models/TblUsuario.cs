using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblUsuario
{
    public int? IdUsuario { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string? Dni { get; set; }

    public DateTime? FechaNac { get; set; }

    public string? Sexo { get; set; }

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public string? Email { get; set; }

    public string? UsuarioId { get; set; }

    public string? Contrasena { get; set; }

    public int? UsuarioBloqueado { get; set; }

    public int? IdSequencia { get; set; }

    public int? IdRol { get; set; }
}
