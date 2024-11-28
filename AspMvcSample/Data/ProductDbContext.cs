using Microsoft.EntityFrameworkCore;
using AspMvcSample.Models;

namespace AspMvcSample.Data;

public partial class ProductDbContext : DbContext
{
    public ProductDbContext()
    {
    }

    public ProductDbContext(DbContextOptions<ProductDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Vitamin C", Description = "Supplement", Price = 10.99 },
                new Product { Id = 2, Name = "Face Cleanser", Price = 19.99 },
                new Product { Id = 3, Name = "Candy", Price = 5.49 }
            );
    }
}
