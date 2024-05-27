using System;
using System.Collections.Generic;

namespace AlumnosCrud.Server.Models;

public partial class TblAlumnos
{
    public int id { get; set; }

    public string? primer_nombre { get; set; }

    public string? segundo_nombre { get; set; }

    public string? primer_apellido { get; set; }

    public string? segundo_apellido { get; set; }

    public string? genero { get; set; }

    public string? lugar_nacimiento { get; set; }

    public DateTime? fecha_nacimiento { get; set; }

    public string? direccion { get; set; }

    public string? telefono { get; set; }

    public string? region { get; set; }

    public string? escuela_procedencia { get; set; }

    public string? anio_ingreso { get; set; }

    public string? numero_identidad { get; set; }

    public string? tiene_hermanos { get; set; }

    public int? numero_miembros { get; set; }

    public string? nombre_madre { get; set; }

    public string? profesion_madre { get; set; }

    public string? lugar_trabajo_madre { get; set; }

    public string? telefono_madre { get; set; }

    public string? celular_madre { get; set; }

    public string? nombre_padre { get; set; }

    public string? profesion_padre { get; set; }

    public string? lugar_trabajo_padre { get; set; }

    public string? telefono_padre { get; set; }

    public string? celular_padre { get; set; }

    public string? ausencia_nombre1 { get; set; }

    public string? ausencia_nombre2 { get; set; }

    public string? ausencia_nombre3 { get; set; }

    public string? parentesco1 { get; set; }

    public string? parentesco2 { get; set; }

    public string? parentesco3 { get; set; }

    public string? telefono_ausencia1 { get; set; }

    public string? telefono_ausencia2 { get; set; }

    public string? telefono_ausencia3 { get; set; }

    public string? estado_civil_padres { get; set; }

    public string? con_quien_vive_alumno { get; set; }

    public string? observaciones { get; set; }

    
}
