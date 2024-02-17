using Microsoft.EntityFrameworkCore;
using ShopFusion.Services.ProductAPI.Models;

namespace ShopFusion.Services.ProductAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                ProductName = "Men Regular Fit Checkered Spread Collar Casual Shirt",
                ProductDescription = "",
                ProductImage = "https://rukminim2.flixcart.com/image/832/832/xif0q/shirt/q/7/a/l-men-regular-fit-printed-spread-collar-casual-shirt-dhruva-original-imagueaqamscp4es.jpeg?q=70&crop=false",
                ProductPrice = 850,
                CategoryName = "Mens T-Shirts",
                CategoryId=1,
                SubCategoryName = "RM CREATION",
                SubCategoryId=1


           });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                ProductName = "Men Regular Fit Printed Spread Collar Casual Shirt",
                ProductDescription = "",
                ProductImage = "",
                ProductPrice = 1299,
                CategoryName = "Mens T-Shirts",
                CategoryId=1,
                SubCategoryName = "RM CREATION",
                SubCategoryId = 1
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                ProductName = "Men Regular Fit Printed Spread Collar Casual Shirt",
                ProductDescription = "",
                ProductImage = "",
                ProductPrice = 999,
                CategoryName = "Mens T-Shirts",
                CategoryId=1,
                SubCategoryName = "RM CREATION",
                SubCategoryId = 1
            });
        }
    }
}
