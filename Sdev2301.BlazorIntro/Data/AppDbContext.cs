namespace Sdev2301.BlazorIntro.Data
{
    using Microsoft.EntityFrameworkCore;
    using Sdev2301.BlazorIntro.Models;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Sku = "KEY-100",
                    Name = "Keyboard",
                    Price = 49.99m,
                    IsActive = true
                },
                new Product
                {
                    Id = 2,
                    Sku = "MOU-200",
                    Name = "Mouse",
                    Price = 24.99m,
                    IsActive = true
                }
            );

            modelBuilder.Entity<Category>().HasData(
               new Category { Id = 1, Name = "Accessories" },
               new Category { Id = 2, Name = "Electronics" },
               new Category { Id = 3, Name = "Office Supplies" }
           );
        }
    }
}
