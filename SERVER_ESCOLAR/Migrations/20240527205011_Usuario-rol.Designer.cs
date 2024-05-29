﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SERVER_ESCOLAR.Models;

#nullable disable

namespace SERVER_ESCOLAR.Migrations
{
    [DbContext(typeof(Models.AppContextDB))]
    [Migration("20240527205011_Usuario-rol")]
    partial class Usuariorol
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SERVER_ESCOLAR.Models.Rol", b =>
                {
                    b.Property<int>("IdRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRol"));

                    b.Property<string>("DescripcionRol")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdRol");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("SERVER_ESCOLAR.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("IdRol")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("RolIdRol")
                        .HasColumnType("int");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<int>("UsuarioBloqueado")
                        .HasColumnType("int");

                    b.HasKey("IdUsuario");

                    b.HasIndex("Correo")
                        .IsUnique();

                    b.HasIndex("IdRol");

                    b.HasIndex("RolIdRol");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SERVER_ESCOLAR.Models.Usuario", b =>
                {
                    b.HasOne("SERVER_ESCOLAR.Models.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("IdRol");

                    b.HasOne("SERVER_ESCOLAR.Models.Rol", null)
                        .WithMany("Usuarios")
                        .HasForeignKey("RolIdRol");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("SERVER_ESCOLAR.Models.Rol", b =>
                {
                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}