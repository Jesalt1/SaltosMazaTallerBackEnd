using Microsoft.EntityFrameworkCore;

namespace SaltosMazaBackEnd.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Genero> generos { get; set; }

    }
}
