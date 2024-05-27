using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AlumnosCrud.Server.Models;

public partial class DbSistemaEscolarContext : DbContext
{
    public DbSistemaEscolarContext()
    {
    }

    public DbSistemaEscolarContext(DbContextOptions<DbSistemaEscolarContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblAgencia> TblAgencias { get; set; }

    public virtual DbSet<TblAlumnos> TblAlumnos { get; set; }

    public virtual DbSet<TblAlumnosConductum> TblAlumnosConducta { get; set; }

    public virtual DbSet<TblAlumnosHi> TblAlumnosHis { get; set; }

    public virtual DbSet<TblAlumnosXSeccion> TblAlumnosXSeccions { get; set; }

    public virtual DbSet<TblAlumnosXTransporte> TblAlumnosXTransportes { get; set; }

    public virtual DbSet<TblAsignatura> TblAsignaturas { get; set; }

    public virtual DbSet<TblAsignaturasCatedratico> TblAsignaturasCatedraticos { get; set; }

    public virtual DbSet<TblAsignaturasRetrasada> TblAsignaturasRetrasadas { get; set; }

    public virtual DbSet<TblAsignaturasXGrado> TblAsignaturasXGrados { get; set; }

    public virtual DbSet<TblBanco> TblBancos { get; set; }

    public virtual DbSet<TblCalificaciones2x2> TblCalificaciones2x2s { get; set; }

    public virtual DbSet<TblCalificaciones4x4> TblCalificaciones4x4s { get; set; }

    public virtual DbSet<TblColaboradore> TblColaboradores { get; set; }

    public virtual DbSet<TblColonia> TblColonias { get; set; }

    public virtual DbSet<TblDepartamento> TblDepartamentos { get; set; }

    public virtual DbSet<TblDescuento> TblDescuentos { get; set; }

    public virtual DbSet<TblEstadosConductum> TblEstadosConducta { get; set; }

    public virtual DbSet<TblGrado> TblGrados { get; set; }

    public virtual DbSet<TblHistoricaCalificaciones2x2> TblHistoricaCalificaciones2x2s { get; set; }

    public virtual DbSet<TblHistoricaCalificaciones4x4> TblHistoricaCalificaciones4x4s { get; set; }

    public virtual DbSet<TblHistoricaMatricula> TblHistoricaMatriculas { get; set; }

    public virtual DbSet<TblHistoricaPagosMatricula> TblHistoricaPagosMatriculas { get; set; }

    public virtual DbSet<TblHistoricaPagosXAlumno> TblHistoricaPagosXAlumnos { get; set; }

    public virtual DbSet<TblHistoricaPagosXAlumnoRealizado> TblHistoricaPagosXAlumnoRealizados { get; set; }

    public virtual DbSet<TblIntere> TblInteres { get; set; }

    public virtual DbSet<TblJornada> TblJornadas { get; set; }

    public virtual DbSet<TblMatricula> TblMatriculas { get; set; }

    public virtual DbSet<TblMunicipio> TblMunicipios { get; set; }

    public virtual DbSet<TblPagosMatricula> TblPagosMatriculas { get; set; }

    public virtual DbSet<TblPagosXAlumno> TblPagosXAlumnos { get; set; }

    public virtual DbSet<TblPagosXAlumnoRealizado> TblPagosXAlumnoRealizados { get; set; }

    public virtual DbSet<TblParamRangosNota> TblParamRangosNotas { get; set; }

    public virtual DbSet<TblReligion> TblReligions { get; set; }

    public virtual DbSet<TblRole> TblRoles { get; set; }

    public virtual DbSet<TblSeccion> TblSeccions { get; set; }

    public virtual DbSet<TblTipoMatricula> TblTipoMatriculas { get; set; }

    public virtual DbSet<TblTipoPago> TblTipoPagos { get; set; }

    public virtual DbSet<TblTiposColaborador> TblTiposColaboradors { get; set; }

    public virtual DbSet<TblTiposMatriculaCondicionadum> TblTiposMatriculaCondicionada { get; set; }

    public virtual DbSet<TblTransporte> TblTransportes { get; set; }

    public virtual DbSet<TblUsuario> TblUsuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblAgencia>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_agencias");

            entity.Property(e => e.Agencia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("agencia");
            entity.Property(e => e.CodigoAgencia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codigo_agencia");
            entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");
            entity.Property(e => e.IdBanco).HasColumnName("id_banco");
            entity.Property(e => e.IdSequencia)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_sequencia");
        });

        modelBuilder.Entity<TblAlumnos>(entity =>
        {
            entity.ToTable("tbl_alumnos");


            entity.Property(e => e.id)
                .ValueGeneratedNever()
                .HasColumnName("id");

            entity.Property(e => e.anio_ingreso)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("anio_ingreso");

            entity.Property(e => e.ausencia_nombre1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ausencia_nombre1");

            entity.Property(e => e.ausencia_nombre2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ausencia_nombre2");

            entity.Property(e => e.ausencia_nombre3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ausencia_nombre3");

            entity.Property(e => e.celular_madre)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("celular_madre");

            entity.Property(e => e.celular_padre)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("celular_padre");

            entity.Property(e => e.con_quien_vive_alumno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("con_quien_vive_alumno");

            entity.Property(e => e.direccion)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("direccion");

            entity.Property(e => e.escuela_procedencia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("escuela_procedencia");

            entity.Property(e => e.estado_civil_padres)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado_civil_padres");

            entity.Property(e => e.fecha_nacimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_nacimiento");

            entity.Property(e => e.genero)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("genero");

            entity.Property(e => e.lugar_nacimiento)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("lugar_nacimiento");

            entity.Property(e => e.lugar_trabajo_madre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lugar_trabajo_madre");

            entity.Property(e => e.lugar_trabajo_padre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lugar_trabajo_padre");

            entity.Property(e => e.nombre_madre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_madre");

            entity.Property(e => e.nombre_padre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_padre");

            entity.Property(e => e.numero_identidad)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("numero_identidad");

            entity.Property(e => e.numero_miembros)
                .HasColumnName("numero_miembros");

            entity.Property(e => e.observaciones)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("observaciones");

            entity.Property(e => e.parentesco1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("parentesco1");

            entity.Property(e => e.parentesco2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("parentesco2");

            entity.Property(e => e.parentesco3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("parentesco3");

            entity.Property(e => e.primer_apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("primer_apellido");

            entity.Property(e => e.primer_nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("primer_nombre");

            entity.Property(e => e.profesion_madre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("profesion_madre");

            entity.Property(e => e.profesion_padre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("profesion_padre");

            entity.Property(e => e.region)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("region");

            entity.Property(e => e.segundo_apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("segundo_apellido");

            entity.Property(e => e.segundo_nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("segundo_nombre");

            entity.Property(e => e.telefono)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("telefono");

            entity.Property(e => e.telefono_ausencia1)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("telefono_ausencia1");

            entity.Property(e => e.telefono_ausencia2)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("telefono_ausencia2");

            entity.Property(e => e.telefono_ausencia3)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("telefono_ausencia3");

            entity.Property(e => e.telefono_madre)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("telefono_madre");

            entity.Property(e => e.telefono_padre)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("telefono_padre");

            entity.Property(e => e.tiene_hermanos)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("tiene_hermanos");

        });

        modelBuilder.Entity<TblAlumnosConductum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_alumnos_conducta");

            entity.Property(e => e.IdAlumno).HasColumnName("id_alumno");
            entity.Property(e => e.IdAsignatura).HasColumnName("id_asignatura");
            entity.Property(e => e.IdConducta).HasColumnName("id_conducta");
            entity.Property(e => e.IdGrado).HasColumnName("id_grado");
            entity.Property(e => e.IdSequencia)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_sequencia");
        });

        modelBuilder.Entity<TblAlumnosHi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_alumnos#his");

            entity.Property(e => e.AnioIngreso)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("anio_ingreso");
            entity.Property(e => e.AusenciaNombre1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ausencia_nombre1");
            entity.Property(e => e.AusenciaNombre2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ausencia_nombre2");
            entity.Property(e => e.AusenciaNombre3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ausencia_nombre3");
            entity.Property(e => e.CelularMadre)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("celular_madre");
            entity.Property(e => e.CelularPadre)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("celular_padre");
            entity.Property(e => e.ConQuienViveAlumno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("con_quien_vive_alumno");
            entity.Property(e => e.Direccion)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.EscuelaProcedencia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("escuela_procedencia");
            entity.Property(e => e.EstadoCivilPadres)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado_civil_padres");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_nacimiento");
            entity.Property(e => e.Genero)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("genero");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdSequencia)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_sequencia");
            entity.Property(e => e.LugarNacimiento)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("lugar_nacimiento");
            entity.Property(e => e.LugarTrabajoMadre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lugar_trabajo_madre");
            entity.Property(e => e.LugarTrabajoPadre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lugar_trabajo_padre");
            entity.Property(e => e.NombreMadre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_madre");
            entity.Property(e => e.NombrePadre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_padre");
            entity.Property(e => e.NumeroIdentidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numero_identidad");
            entity.Property(e => e.NumeroMiembros).HasColumnName("numero_miembros");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Parentesco1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("parentesco1");
            entity.Property(e => e.Parentesco2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("parentesco2");
            entity.Property(e => e.Parentesco3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("parentesco3");
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("primer_apellido");
            entity.Property(e => e.PrimerNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("primer_nombre");
            entity.Property(e => e.ProfesionMadre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("profesion_madre");
            entity.Property(e => e.ProfesionPadre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("profesion_padre");
            entity.Property(e => e.Region)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("region");
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("segundo_apellido");
            entity.Property(e => e.SegundoNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("segundo_nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.TelefonoAusencia1)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("telefono_ausencia1");
            entity.Property(e => e.TelefonoAusencia2)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("telefono_ausencia2");
            entity.Property(e => e.TelefonoAusencia3)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("telefono_ausencia3");
            entity.Property(e => e.TelefonoMadre)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("telefono_madre");
            entity.Property(e => e.TelefonoPadre)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("telefono_padre");
            entity.Property(e => e.TieneHermanos)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("tiene_hermanos");
        });

        modelBuilder.Entity<TblAlumnosXSeccion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_alumnos_x_seccion");

            entity.Property(e => e.IdAlumno).HasColumnName("id_alumno");
            entity.Property(e => e.IdGrado).HasColumnName("id_grado");
            entity.Property(e => e.IdSeccion).HasColumnName("id_seccion");
        });

        modelBuilder.Entity<TblAlumnosXTransporte>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_alumnos_x_transporte");

            entity.Property(e => e.IdAlumno).HasColumnName("id_alumno");
            entity.Property(e => e.IdTransporteEntrada).HasColumnName("id_transporte_entrada");
            entity.Property(e => e.IdTransporteSalida).HasColumnName("id_transporte_salida");
            entity.Property(e => e.Precio)
                .HasColumnType("money")
                .HasColumnName("precio");
        });

        modelBuilder.Entity<TblAsignatura>(entity =>
        {
            entity.HasKey(e => e.IdAsignatura).HasName("PK__tbl_asig__33A22F4C459B8DC7");

            entity.ToTable("tbl_asignaturas");

            entity.Property(e => e.IdAsignatura).HasColumnName("id_asignatura");
            entity.Property(e => e.NombreAsignatura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_asignatura");
        });

        modelBuilder.Entity<TblAsignaturasCatedratico>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_asignaturas_catedratico");

            entity.Property(e => e.IdAsignatura).HasColumnName("id_asignatura");
            entity.Property(e => e.IdColaborador).HasColumnName("id_colaborador");
            entity.Property(e => e.IdGrado).HasColumnName("id_grado");
            entity.Property(e => e.IdSeccion).HasColumnName("id_seccion");
        });

        modelBuilder.Entity<TblAsignaturasRetrasada>(entity =>
        {
            entity.HasKey(e => e.IdAsignaturaRetrasada).HasName("PK__tbl_asig__33534F861B77C24C");

            entity.ToTable("tbl_asignaturas_retrasadas");

            entity.Property(e => e.IdAsignaturaRetrasada).HasColumnName("id_asignatura_retrasada");
            entity.Property(e => e.Estado)
                .HasMaxLength(100)
                .HasColumnName("estado");
            entity.Property(e => e.IdAlumno).HasColumnName("id_alumno");
            entity.Property(e => e.IdAsignatura).HasColumnName("id_asignatura");
            entity.Property(e => e.IdGrado).HasColumnName("id_grado");
            entity.Property(e => e.Precio)
                .HasColumnType("money")
                .HasColumnName("precio");
        });

        modelBuilder.Entity<TblAsignaturasXGrado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_asignaturas_x_grado");

            entity.Property(e => e.IdAsignatura).HasColumnName("id_asignatura");
            entity.Property(e => e.IdGrado).HasColumnName("id_grado");
        });

        modelBuilder.Entity<TblBanco>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_bancos");

            entity.Property(e => e.Banco)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("banco");
            entity.Property(e => e.IdBanco).HasColumnName("id_banco");
            entity.Property(e => e.IdSequencia)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_sequencia");
            entity.Property(e => e.NumeroCuenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numero_cuenta");
        });

        modelBuilder.Entity<TblCalificaciones2x2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TBL_CALIFICACIONES_2X_2");

            entity.Property(e => e.AsignaturaRetrasada).HasColumnName("ASIGNATURA_RETRASADA");
            entity.Property(e => e.IdAlumno).HasColumnName("ID_ALUMNO");
            entity.Property(e => e.IdAsignatura).HasColumnName("ID_ASIGNATURA");
            entity.Property(e => e.IdSemestre).HasColumnName("ID_SEMESTRE");
            entity.Property(e => e.Nota1).HasColumnName("NOTA1");
            entity.Property(e => e.Nota2).HasColumnName("NOTA2");
            entity.Property(e => e.Promedio).HasColumnName("PROMEDIO");
        });

        modelBuilder.Entity<TblCalificaciones4x4>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TBL_CALIFICACIONES_4X_4");

            entity.Property(e => e.AsignaturaRetrasada).HasColumnName("ASIGNATURA_RETRASADA");
            entity.Property(e => e.IdAlumno).HasColumnName("ID_ALUMNO");
            entity.Property(e => e.IdAsignatura).HasColumnName("ID_ASIGNATURA");
            entity.Property(e => e.Nota1).HasColumnName("NOTA1");
            entity.Property(e => e.Nota2).HasColumnName("NOTA2");
            entity.Property(e => e.Nota3).HasColumnName("NOTA3");
            entity.Property(e => e.Nota4).HasColumnName("NOTA4");
            entity.Property(e => e.Promedio).HasColumnName("PROMEDIO");
        });

        modelBuilder.Entity<TblColaboradore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tbl_cola__3213E83FA67A490F");

            entity.ToTable("tbl_colaboradores");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Direccion)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_nacimiento");
            entity.Property(e => e.Genero)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("genero");
            entity.Property(e => e.LugarNacimiento)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("lugar_nacimiento");
            entity.Property(e => e.NumeroIdentidad)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("numero_identidad");
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("primer_apellido");
            entity.Property(e => e.PrimerNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("primer_nombre");
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("segundo_apellido");
            entity.Property(e => e.SegundoNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("segundo_nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.TipoColaborador).HasColumnName("tipo_colaborador");
        });

        modelBuilder.Entity<TblColonia>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_colonias");

            entity.Property(e => e.Colonia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("colonia");
            entity.Property(e => e.IdColonia).HasColumnName("id_colonia");
            entity.Property(e => e.IdMunicipio).HasColumnName("id_municipio");
            entity.Property(e => e.IdSequencia)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_sequencia");
        });

        modelBuilder.Entity<TblDepartamento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_departamentos");

            entity.Property(e => e.Depto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("depto");
            entity.Property(e => e.IdDepto).HasColumnName("id_depto");
            entity.Property(e => e.IdSequencia)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_sequencia");
        });

        modelBuilder.Entity<TblDescuento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_descuentos");

            entity.Property(e => e.DescripcionDescuento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion_descuento");
            entity.Property(e => e.IdDescuento).HasColumnName("id_descuento");
            entity.Property(e => e.IdSequencia)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_sequencia");
            entity.Property(e => e.PorcentajeDescuento).HasColumnName("porcentaje_descuento");
        });

        modelBuilder.Entity<TblEstadosConductum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_estados_conducta");

            entity.Property(e => e.DescripcionConducta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion_conducta");
            entity.Property(e => e.IdEstadoConducta).HasColumnName("id_estado_conducta");
            entity.Property(e => e.IdSequencia)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_sequencia");
        });

        modelBuilder.Entity<TblGrado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_grados");

            entity.Property(e => e.Grado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("grado");
            entity.Property(e => e.IdGrado).HasColumnName("id_grado");
            entity.Property(e => e.IdSequencia)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_sequencia");
        });

        modelBuilder.Entity<TblHistoricaCalificaciones2x2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_historica_calificaciones_2x_2");

            entity.Property(e => e.Anio).HasColumnName("ANIO");
            entity.Property(e => e.Asignatura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ASIGNATURA");
            entity.Property(e => e.AsignaturaRetrasada).HasColumnName("ASIGNATURA_RETRASADA");
            entity.Property(e => e.Grado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GRADO");
            entity.Property(e => e.IdAlumno).HasColumnName("ID_ALUMNO");
            entity.Property(e => e.IdCatedratico).HasColumnName("ID_CATEDRATICO");
            entity.Property(e => e.IdSemestre).HasColumnName("ID_SEMESTRE");
            entity.Property(e => e.Nota1).HasColumnName("NOTA1");
            entity.Property(e => e.Nota2).HasColumnName("NOTA2");
            entity.Property(e => e.Promedio).HasColumnName("PROMEDIO");
            entity.Property(e => e.Seccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SECCION");
        });

        modelBuilder.Entity<TblHistoricaCalificaciones4x4>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_historica_calificaciones_4x_4");

            entity.Property(e => e.Anio).HasColumnName("ANIO");
            entity.Property(e => e.Asignatura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ASIGNATURA");
            entity.Property(e => e.AsignaturaRetrasada).HasColumnName("ASIGNATURA_RETRASADA");
            entity.Property(e => e.Grado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GRADO");
            entity.Property(e => e.IdAlumno).HasColumnName("ID_ALUMNO");
            entity.Property(e => e.IdCatedratico).HasColumnName("ID_CATEDRATICO");
            entity.Property(e => e.Nota1).HasColumnName("NOTA1");
            entity.Property(e => e.Nota2).HasColumnName("NOTA2");
            entity.Property(e => e.Nota3).HasColumnName("NOTA3");
            entity.Property(e => e.Nota4).HasColumnName("NOTA4");
            entity.Property(e => e.Promedio).HasColumnName("PROMEDIO");
            entity.Property(e => e.Seccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SECCION");
        });

        modelBuilder.Entity<TblHistoricaMatricula>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_historica_matricula");

            entity.Property(e => e.Agencia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("agencia");
            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Banco)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("banco");
            entity.Property(e => e.DescuentoMatricula).HasColumnName("descuento_matricula");
            entity.Property(e => e.DescuentoMensualidad).HasColumnName("descuento_mensualidad");
            entity.Property(e => e.DescuentoTransporte).HasColumnName("descuento_transporte");
            entity.Property(e => e.FechaMatricula)
                .HasColumnType("datetime")
                .HasColumnName("fecha_matricula");
            entity.Property(e => e.Grado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("grado");
            entity.Property(e => e.IdAlumno).HasColumnName("id_alumno");
            entity.Property(e => e.IdGrado).HasColumnName("id_grado");
            entity.Property(e => e.IdJornada).HasColumnName("id_jornada");
            entity.Property(e => e.IdMatricula).HasColumnName("id_matricula");
            entity.Property(e => e.IdSeccion).HasColumnName("id_seccion");
            entity.Property(e => e.IdTipoMatricula).HasColumnName("id_tipo_matricula");
            entity.Property(e => e.MatriculaCondicionada).HasColumnName("matricula_condicionada");
            entity.Property(e => e.MatriculadoPor)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("matriculado_por");
            entity.Property(e => e.NombreAlumno)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("nombre_alumno");
            entity.Property(e => e.NumeroCuenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numero_cuenta");
            entity.Property(e => e.NumeroIdentidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("numero_identidad");
            entity.Property(e => e.Seccion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("seccion");
            entity.Property(e => e.TipoCondicionada)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tipo_condicionada");
            entity.Property(e => e.TipoIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tipo_ingreso");
            entity.Property(e => e.TipoPago)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("tipo_pago");
            entity.Property(e => e.UtilizaTransporte).HasColumnName("utiliza_transporte");
        });

        modelBuilder.Entity<TblHistoricaPagosMatricula>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_historica_pagos_matricula");

            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Grado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("grado");
            entity.Property(e => e.IdGrado).HasColumnName("id_grado");
            entity.Property(e => e.IdPago).HasColumnName("id_pago");
            entity.Property(e => e.NumeroPagos).HasColumnName("numero_pagos");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.OtrosGastos)
                .HasColumnType("money")
                .HasColumnName("otros_gastos");
            entity.Property(e => e.PagoGastosGraduacion)
                .HasColumnType("money")
                .HasColumnName("pago_gastos_graduacion");
            entity.Property(e => e.PagoMensualidad)
                .HasColumnType("money")
                .HasColumnName("pago_mensualidad");
            entity.Property(e => e.PrecioMatricula)
                .HasColumnType("money")
                .HasColumnName("precio_matricula");
            entity.Property(e => e.PrecioSeguro)
                .HasColumnType("money")
                .HasColumnName("precio_seguro");
        });

        modelBuilder.Entity<TblHistoricaPagosXAlumno>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_historica_pagos_x_alumno");

            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fecha_vencimiento");
            entity.Property(e => e.IdAlumno).HasColumnName("id_alumno");
            entity.Property(e => e.IdPago).HasColumnName("id_pago");
            entity.Property(e => e.IdTipoPago).HasColumnName("id_tipo_pago");
            entity.Property(e => e.TotalAPagar)
                .HasColumnType("money")
                .HasColumnName("total_a_pagar");
        });

        modelBuilder.Entity<TblHistoricaPagosXAlumnoRealizado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_historica_pagos_x_alumno_realizados");

            entity.Property(e => e.Agencia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("agencia");
            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IdAlumno).HasColumnName("id_alumno");
            entity.Property(e => e.IdBanco).HasColumnName("id_banco");
            entity.Property(e => e.IdPago).HasColumnName("id_pago");
            entity.Property(e => e.IdTipoPago).HasColumnName("id_tipo_pago");
            entity.Property(e => e.MetodoPago)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("metodo_pago");
            entity.Property(e => e.NumeroCuenta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numero_cuenta");
            entity.Property(e => e.Recargo)
                .HasColumnType("money")
                .HasColumnName("recargo");
            entity.Property(e => e.TotalPagado)
                .HasColumnType("money")
                .HasColumnName("total_pagado");
        });

        modelBuilder.Entity<TblIntere>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_interes");

            entity.Property(e => e.DescripcionInteres)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion_interes");
            entity.Property(e => e.IdGrado).HasColumnName("id_grado");
            entity.Property(e => e.IdInteres).HasColumnName("id_interes");
            entity.Property(e => e.IdSequencia)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_sequencia");
            entity.Property(e => e.PorcentajeInteres)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("porcentaje_interes");
        });

        modelBuilder.Entity<TblJornada>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_jornadas");

            entity.Property(e => e.IdJornada).HasColumnName("id_jornada");
            entity.Property(e => e.IdSequencia)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_sequencia");
            entity.Property(e => e.Jornada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("jornada");
        });

        modelBuilder.Entity<TblMatricula>(entity =>
        {
            entity.HasKey(e => e.IdAlumno);

            entity.ToTable("tbl_matricula");

            entity.Property(e => e.IdAlumno)
                .ValueGeneratedNever()
                .HasColumnName("id_alumno");
            entity.Property(e => e.FechaMatricula)
                .HasColumnType("datetime")
                .HasColumnName("fecha_matricula");
            entity.Property(e => e.IdAgencia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_agencia");
            entity.Property(e => e.IdBanco).HasColumnName("id_banco");
            entity.Property(e => e.IdCodigoAgencia).HasColumnName("id_codigo_agencia");
            entity.Property(e => e.IdDescuentoMatricula).HasColumnName("id_descuento_matricula");
            entity.Property(e => e.IdDescuentoMensualidad).HasColumnName("id_descuento_mensualidad");
            entity.Property(e => e.IdDescuentoTransporte).HasColumnName("id_descuento_transporte");
            entity.Property(e => e.IdGrado).HasColumnName("id_grado");
            entity.Property(e => e.IdJornada).HasColumnName("id_jornada");
            entity.Property(e => e.IdMatricula).HasColumnName("id_matricula");
            entity.Property(e => e.IdNumeroCuenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_numero_cuenta");
            entity.Property(e => e.IdSeccion).HasColumnName("id_seccion");
            entity.Property(e => e.IdSequencia)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_sequencia");
            entity.Property(e => e.IdTipoMatricula).HasColumnName("id_tipo_matricula");
            entity.Property(e => e.Matricula).HasColumnName("matricula");
            entity.Property(e => e.MatriculaCondicionada).HasColumnName("matricula_condicionada");
            entity.Property(e => e.MatriculadoPor)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("matriculado_por");
            entity.Property(e => e.NombreAlumno)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("nombre_alumno");
            entity.Property(e => e.NumeroIdentidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("numero_identidad");
            entity.Property(e => e.PreMatricula).HasColumnName("pre_matricula");
            entity.Property(e => e.Retirado).HasColumnName("retirado");
            entity.Property(e => e.TipoCondicionada).HasColumnName("tipo_condicionada");
            entity.Property(e => e.TipoIngreso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tipo_ingreso");
            entity.Property(e => e.TipoPago)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("tipo_pago");
            entity.Property(e => e.UtilizaTransporte).HasColumnName("utiliza_transporte");
        });

        modelBuilder.Entity<TblMunicipio>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_municipios");

            entity.Property(e => e.IdDepto).HasColumnName("id_depto");
            entity.Property(e => e.IdMunicipio).HasColumnName("id_municipio");
            entity.Property(e => e.IdSequencia)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_sequencia");
            entity.Property(e => e.Municipio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("municipio");
        });

        modelBuilder.Entity<TblPagosMatricula>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_pagos_matricula");

            entity.Property(e => e.IdGrado).HasColumnName("id_grado");
            entity.Property(e => e.IdPago).HasColumnName("id_pago");
            entity.Property(e => e.IdSequencia)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_sequencia");
            entity.Property(e => e.NumeroPagos).HasColumnName("numero_pagos");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.OtrosGastos)
                .HasColumnType("money")
                .HasColumnName("otros_gastos");
            entity.Property(e => e.PagoGastosGraduacion)
                .HasColumnType("money")
                .HasColumnName("pago_gastos_graduacion");
            entity.Property(e => e.PagoMensualidad)
                .HasColumnType("money")
                .HasColumnName("pago_mensualidad");
            entity.Property(e => e.PrecioMatricula)
                .HasColumnType("money")
                .HasColumnName("precio_matricula");
            entity.Property(e => e.PrecioSeguro)
                .HasColumnType("money")
                .HasColumnName("precio_seguro");
        });

        modelBuilder.Entity<TblPagosXAlumno>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_pagos_x_alumno");

            entity.Property(e => e.FechaVencimiento).HasColumnName("fecha_vencimiento");
            entity.Property(e => e.IdAlumno).HasColumnName("id_alumno");
            entity.Property(e => e.IdPago).HasColumnName("id_pago");
            entity.Property(e => e.IdTipoPago).HasColumnName("id_tipo_pago");
            entity.Property(e => e.TotalAPagar)
                .HasColumnType("money")
                .HasColumnName("total_a_pagar");
        });

        modelBuilder.Entity<TblPagosXAlumnoRealizado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_pagos_x_alumno_realizados");

            entity.Property(e => e.Agencia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("agencia");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IdAlumno).HasColumnName("id_alumno");
            entity.Property(e => e.IdBanco).HasColumnName("id_banco");
            entity.Property(e => e.IdPago).HasColumnName("id_pago");
            entity.Property(e => e.IdTipoPago).HasColumnName("id_tipo_pago");
            entity.Property(e => e.MetodoPago)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("metodo_pago");
            entity.Property(e => e.NumeroCuenta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numero_cuenta");
            entity.Property(e => e.Recargo)
                .HasColumnType("money")
                .HasColumnName("recargo");
            entity.Property(e => e.TotalPagado)
                .HasColumnType("money")
                .HasColumnName("total_pagado");
        });

        modelBuilder.Entity<TblParamRangosNota>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_param_rangos_notas");

            entity.Property(e => e.IdRangoNotas).HasColumnName("id_rango_notas");
            entity.Property(e => e.IdSequencia)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_sequencia");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.RangoFinal).HasColumnName("rango_final");
            entity.Property(e => e.RangoInicial).HasColumnName("rango_inicial");
        });

        modelBuilder.Entity<TblReligion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_religion");

            entity.Property(e => e.IdReligion).HasColumnName("id_religion");
            entity.Property(e => e.IdSequencia)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_sequencia");
            entity.Property(e => e.Religion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("religion");
        });

        modelBuilder.Entity<TblRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_roles");

            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.IdSequencia).HasColumnName("id_sequencia");
            entity.Property(e => e.Rol)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rol");
        });

        modelBuilder.Entity<TblSeccion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_seccion");

            entity.Property(e => e.IdGrado).HasColumnName("id_grado");
            entity.Property(e => e.IdSeccion).HasColumnName("id_seccion");
            entity.Property(e => e.IdSequencia)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_sequencia");
            entity.Property(e => e.Seccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("seccion");
        });

        modelBuilder.Entity<TblTipoMatricula>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_tipo_matricula");

            entity.Property(e => e.IdSequencia)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_sequencia");
            entity.Property(e => e.IdTipoMatricula).HasColumnName("id_tipo_matricula");
            entity.Property(e => e.TipoMatricula)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_matricula");
        });

        modelBuilder.Entity<TblTipoPago>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_tipo_pago");

            entity.Property(e => e.IdTipoPago)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_tipo_pago");
            entity.Property(e => e.TipoPago)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("tipo_pago");
        });

        modelBuilder.Entity<TblTiposColaborador>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_tipos_colaborador");

            entity.Property(e => e.DescripcionColaborador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion_colaborador");
            entity.Property(e => e.IdSequencia)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_sequencia");
            entity.Property(e => e.IdTiposColaborador).HasColumnName("id_tipos_colaborador");
        });

        modelBuilder.Entity<TblTiposMatriculaCondicionadum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_tipos_matricula_condicionada");

            entity.Property(e => e.IdMatriculaCondicionada).HasColumnName("id_matricula_condicionada");
            entity.Property(e => e.IdSequencia)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_sequencia");
            entity.Property(e => e.MatriculaCondicionada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("matricula_condicionada");
        });

        modelBuilder.Entity<TblTransporte>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_transporte");

            entity.Property(e => e.CodigoTransporte)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codigo_transporte");
            entity.Property(e => e.IdSequencia)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_sequencia");
            entity.Property(e => e.IdTransporte).HasColumnName("id_transporte");
            entity.Property(e => e.Ruta)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("ruta");
        });

        modelBuilder.Entity<TblUsuario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_usuarios");

            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("contrasena");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Dni)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FechaNac)
                .HasColumnType("datetime")
                .HasColumnName("fecha_nac");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.IdSequencia).HasColumnName("id_sequencia");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Nombres)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("sexo");
            entity.Property(e => e.Telefono)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.UsuarioBloqueado).HasColumnName("usuario_bloqueado");
            entity.Property(e => e.UsuarioId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usuario_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
