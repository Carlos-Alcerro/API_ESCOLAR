    using Microsoft.EntityFrameworkCore;

namespace SERVER_ESCOLAR.Models
{
    public class UsuariosContext: DbContext
    {
        public UsuariosContext(DbContextOptions<UsuariosContext>options): base(options) { 
        
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>().HasIndex(c => c.Correo).IsUnique();
        }
    }
}
