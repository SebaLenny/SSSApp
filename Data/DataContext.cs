using Microsoft.EntityFrameworkCore;
using SSSApp.API.Models;

namespace SSSApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Conditions> Conditions { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Rally> Rallies { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<Track> Tracks { get; set; }

    }
}