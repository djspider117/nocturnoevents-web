using Microsoft.EntityFrameworkCore;

namespace NocturnoWeb.Data
{
    public class NocturnoDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Artist> Artists { get; set; }

        public DbSet<EventArtistMapping> EventArtistMapping { get; set; }

        public NocturnoDbContext()
        {

        }

        public NocturnoDbContext(DbContextOptions<NocturnoDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source=nocturno.db");
    }
}
