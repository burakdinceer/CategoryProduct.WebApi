using CategoryProduct.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CategoryProduct.WebApi.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(x => x.Price).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ProductCategory>().HasKey(x => new { x.CategoryId, x.ProductId });



            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductCategory> productCategories { get; set; }

    }
}