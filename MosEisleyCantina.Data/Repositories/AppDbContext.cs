using Microsoft.EntityFrameworkCore;
using MosEisleyCantina.Data.Repositories.Entities;

namespace MosEisleyCantina.Data.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MenuItem>()
                .HasOne(m => m.Category)
                .WithMany(c => c.MenuItems)
                .HasForeignKey(m => m.CategoryId);

            modelBuilder.Entity<Rating>()
                .HasOne(r => r.MenuItem)
                .WithMany(m => m.Ratings)
                .HasForeignKey(r => r.MenuItemId);
        }
    }
}
