using Microsoft.EntityFrameworkCore;

namespace Mascotas.Models
{
    public class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions<ContextDB> options) : base(options)
        {

        }
        public DbSet<Mascota> Mascotas { get; set; }

    }
}
