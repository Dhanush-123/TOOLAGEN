// Ensure the correct namespace is used
using Microsoft.EntityFrameworkCore;
using project_DI.Models;  // Assuming your models are in this namespace

namespace ProjectName.Data  // Update your namespace to match your project structure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Optionally, you can seed data here if necessary      
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Sample Product 1", Price = 10.99m, Description = "Description for product 1" },
                new Product { Id = 2, Name = "Sample Product 2", Price = 20.99m, Description = "Description for product 2" },
                new Product { Id = 3, Name = "Sample Product 3", Price = 30.99m, Description = "Description for product 3" }
            );
        }
    }
}
