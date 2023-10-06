using CheckPoint5.Models;
using Microsoft.EntityFrameworkCore;

namespace CheckPoint5.Repositories
{
    public class OracleDbContext: DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }

        public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .Property(p => p.Nome)
                .HasConversion<string>();
        }
    }
}
