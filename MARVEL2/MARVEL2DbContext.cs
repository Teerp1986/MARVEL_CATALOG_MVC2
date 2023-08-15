using MARVEL2.Models;
using Microsoft.EntityFrameworkCore;


namespace MARVEL2
{
    public class MARVEL2DbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Villan> Villans { get; set; }
        public DbSet<MCU_Show> MCU_Shows { get; set; }
        public DbSet<Phase> Phase { get; set; }

        public string DbPath { get; }

        public MARVEL2DbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "MARVEL2Db.db");
        }

        // The following configures EF to create a SqLite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        // The following configures EF to create a SqLite database file in the
        // special "local" folder for your platform.
    }
}
