using Microsoft.EntityFrameworkCore;
using SSSApp.API.Models;

namespace SSSApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Car> Car { get; set; }
        public DbSet<CarCategory> CarCategory { get; set; }
        public DbSet<Conditions> Condition { get; set; }
        public DbSet<Driver> Driver { get; set; }
        public DbSet<RallyEntry> RallyEntry { get; set; }
        public DbSet<Rally> Rally { get; set; }
        public DbSet<Result> Result { get; set; }
        public DbSet<Stage> Stage { get; set; }
        public DbSet<Track> Track { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}