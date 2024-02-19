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
        public DbSet<Brands> Brands { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<SubCategories> SubCategories { get; set; }
        public DbSet<MainCategory> MainCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                ProductName = "Natureland Organics Kabuli Chana (Kabuli Buta) (Whole)  (500 g)",
                ProductDescription = "",
                ProductImage = "https://rukminim2.flixcart.com/image/416/416/ke7ff680/pulses/z/m/x/500-kabuli-chana-kabuli-chana-natureland-organics-original-imafuy3hfkx4qw7d.jpeg?q=70",
                ProductPrice = 126,

                CategoryId = 1,

                SubCategoryId = 1,
                BrandId = 1,

                MainCategoryId = 1,

                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now,
                IsActive = true

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
               Id = 2,
                ProductName = "Natureland Organics Yellow Toor/Arhar Dal (Harada Dali) (Split)  (1 kg)",
                ProductDescription = "",
                ProductImage = "https://rukminim2.flixcart.com/image/416/416/kqpj4i80/pulses/r/a/z/1-arhar-dal-arhar-dal-natureland-organics-original-imag4npb8twt4dwz.jpeg?q=70",
                ProductPrice = 1299,
               
                CategoryId = 1,
              
                SubCategoryId = 1,
                BrandId = 1,
               
                MainCategoryId = 1,
             
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now,
                IsActive = true

            });

         
           modelBuilder.Entity<MainCategory>().HasData(new MainCategory
            {
                Id = 1,
                MainCategoryName = "Staples",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<MainCategory>().HasData(new MainCategory
            {
                Id = 2,
                MainCategoryName = "Snacks & Beverages",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Brands>().HasData(new Brands
            {
              Id = 1,
                BrandName = "Nature Land",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Brands>().HasData(new Brands
            {
                Id = 2,
                BrandName = "Fortune",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Categories>().HasData(new Categories
            {
                Id = 1,
                CategoryName = "Dal's & Pulses",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Categories>().HasData(new Categories
            {
                Id = 2,
                CategoryName = "Ghee & Oils",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<SubCategories>().HasData(new SubCategories
            {
                Id = 1,
                SubCategoryName = "Toor Daal",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<SubCategories>().HasData(new SubCategories
            {
                Id = 2,
                SubCategoryName = "Urad Daal",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });


            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                ProductName = "Tata Sampann White Urad Dal (Biri Dali) (Whole)  (1 kg)",
                ProductDescription = "",
                ProductImage = "https://rukminim2.flixcart.com/image/416/416/xif0q/pulses/g/4/h/-original-imagpgzhcvgcyaxg.jpeg?q=70",
                ProductPrice = 200,
                BrandId = 2,
              
                CategoryId = 1,
              
                SubCategoryId = 2,
                MainCategoryId = 1,
            
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now,
                IsActive = true

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                ProductName = "Natureland Organics Urad Dal (Biri Dali) (Split)  (1 kg)",
                ProductDescription = "",
                ProductImage = "https://rukminim2.flixcart.com/image/416/416/xif0q/pulses/0/g/n/-original-imagsy58yzw47w8f.jpeg?q=70",
                ProductPrice = 200,
                BrandId = 2,
               
                CategoryId = 1,
              
                SubCategoryId = 2,
                MainCategoryId = 1,
             
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now,
                IsActive = true

            });

        }
    }
}
