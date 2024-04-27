using Dadekavan.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Dadekavan.EntityFrameworkCore.DadekavanDbContextApplication
{
    public class DadekavanDbContext : DbContext
    {

        #region MyDbSet
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        #endregion

        public DadekavanDbContext(DbContextOptions<DadekavanDbContext> contextOptions)
        : base(contextOptions)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Database=DadekavanDb;User Id=sa;Password=s@123456;Trusted_Connection=True;TrustServerCertificate=True;")
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
