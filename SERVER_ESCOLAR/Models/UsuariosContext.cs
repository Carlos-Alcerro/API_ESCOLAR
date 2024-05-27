using Microsoft.EntityFrameworkCore;

namespace SERVER_ESCOLAR.Models
{
    public class UsuariosContext : DbContext
    {
        public UsuariosContext(DbContextOptions<UsuariosContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>()
                .HasIndex(c => c.Correo)
                .IsUnique();

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Rol)
                .WithMany()
                .HasForeignKey(u => u.IdRol);

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Nombres).HasMaxLength(255).IsRequired();
                entity.Property(e => e.Apellidos).HasMaxLength(255).IsRequired();
                entity.Property(e => e.Dni).HasMaxLength(50).IsRequired();
                entity.Property(e => e.Contrasena).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Correo).HasMaxLength(50).IsRequired();
                entity.Property(e => e.Sexo).HasMaxLength(1).IsRequired();
                entity.Property(e => e.Direccion).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Telefono).HasMaxLength(9).IsRequired();
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.Property(e => e.DescripcionRol).HasMaxLength(50).IsRequired();
            });
        }
    }
}
