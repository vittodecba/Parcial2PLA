using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Sql
{
    public class StoreDbContext : DbContext
    {
        public DbSet<Automovil> Automoviles { get; set; }

        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }

        protected StoreDbContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Automovil>().ToTable("Automovil");
        }
    }
}