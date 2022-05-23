using Assets.Model;
using Microsoft.EntityFrameworkCore;

namespace Assets.Infra
{
    public class AssetsDbContext : DbContext
    {
        public DbSet<Asset> Assets { get; }
        public AssetsDbContext(DbContextOptions<AssetsDbContext> options) : base(options)
        {
            Database.EnsureCreated();
            Assets = Set<Asset>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssetsDbContext).Assembly);
        }
    }
}