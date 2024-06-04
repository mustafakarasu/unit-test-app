using Microsoft.EntityFrameworkCore;

namespace UnitTestApp.Web.Models
{
    public partial class UnitTestDbContext : DbContext
    {
        public UnitTestDbContext()
        {
        }

        public UnitTestDbContext(DbContextOptions<UnitTestDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Color).HasMaxLength(50);
                entity.Property(e => e.Name).HasMaxLength(200);
                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });
            
        }
    }
}