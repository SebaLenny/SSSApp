using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SSSApp.API.Models;

namespace SSSApp.API.Data
{
    public class DataContext : IdentityDbContext<
        Driver,
        Role,
        int,
        IdentityUserClaim<int>,
        UserRole,
        IdentityUserLogin<int>,
        IdentityRoleClaim<int>,
        IdentityUserToken<int>
    >
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Car> Car { get; set; }
        public DbSet<CarCategory> CarCategory { get; set; }
        public DbSet<Club> Club { get; set; }
        public DbSet<ClubRally> ClubRally { get; set; }
        public DbSet<Conditions> Condition { get; set; }
        public DbSet<Driver> Driver { get; set; }
        public DbSet<RallyEntry> RallyEntry { get; set; }
        public DbSet<Rally> Rally { get; set; }
        public DbSet<Result> Result { get; set; }
        public DbSet<Stage> Stage { get; set; }
        public DbSet<Track> Track { get; set; }
        public DbSet<Order> Order { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserRole>(
                userRole =>
                {
                    userRole.HasKey(ur => new { ur.UserId, ur.RoleId });
                    userRole.HasOne(ur => ur.Role)
                        .WithMany(r => r.UserRoles)
                        .HasForeignKey(ur => ur.RoleId)
                        .IsRequired();
                    userRole.HasOne(ur => ur.User)
                        .WithMany(r => r.UserRoles)
                        .HasForeignKey(ur => ur.UserId)
                        .IsRequired();
                }
            );

            modelBuilder.Entity<ClubRally>()
                .HasKey(cr => new { cr.ClubId, cr.RallyId });
        }
    }
}