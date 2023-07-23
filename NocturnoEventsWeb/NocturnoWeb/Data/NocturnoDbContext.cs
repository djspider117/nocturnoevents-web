using Microsoft.EntityFrameworkCore;

namespace NocturnoWeb.Data
{
    public class NocturnoDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Artist> Artists { get; set; }

        public DbSet<EventArtistMapping> EventArtistMapping { get; set; }

        public string DbPath { get; }

        public NocturnoDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "nocturno.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
