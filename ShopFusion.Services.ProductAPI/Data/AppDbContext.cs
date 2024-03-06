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
            modelBuilder.Entity<Brands>().HasData(new Brands
            {
                Id = 3,
                BrandName = "Patanjali",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Brands>().HasData(new Brands
            {
                Id = 4,
                BrandName = "Fortune",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Brands>().HasData(new Brands
            {
                Id = 5,
                BrandName = "Saffola",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Brands>().HasData(new Brands
            {
                Id = 6,
                BrandName = "Gowardhan",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Categories>().HasData(new Categories
            {
                Id = 1,
                CategoryName = "Dal's & Pulses",
                CategoryImage = "https://rukminim2.flixcart.com/www/100/100/promos/09/06/2017/38deea34-44ce-4650-a1fb-60f1c0172feb.png?q=90",
                MainCategoryId = 1,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Categories>().HasData(new Categories
            {
                Id = 2,
                CategoryName = "Ghee & Oils",
                CategoryImage = "https://rukminim2.flixcart.com/www/100/100/promos/06/11/2023/bab3c31e-0be6-4f67-b9a6-cb341fa1f034.png?q=90",
                MainCategoryId = 1,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Categories>().HasData(new Categories
            {
                Id = 3,
                CategoryName = "Atta & Flours",
                CategoryImage = "https://rukminim2.flixcart.com/www/100/100/promos/05/07/2017/cd819684-9369-468b-895c-ef9b57b6b059.png?q=90",
                MainCategoryId = 1,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<SubCategories>().HasData(new SubCategories
            {
                Id = 1,
                SubCategoryName = "Toor Daal",
                MainCategoryId = 1,
                CategoryId = 1,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<SubCategories>().HasData(new SubCategories
            {
                Id = 2,
                SubCategoryName = "Urad Daal",
                MainCategoryId = 1,
                CategoryId = 1,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<SubCategories>().HasData(new SubCategories
            {
                Id = 3,
                SubCategoryName = "Wheat Atta",
                MainCategoryId = 1,
                CategoryId = 3,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<SubCategories>().HasData(new SubCategories
            {
                Id = 4,
                SubCategoryName = "Rava & Sooji",
                MainCategoryId = 1,
                CategoryId = 3,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<SubCategories>().HasData(new SubCategories
            {
                Id = 5,
                SubCategoryName = "Blended Oil",
                MainCategoryId = 1,
                CategoryId = 2,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<SubCategories>().HasData(new SubCategories
            {
                Id = 6,
                SubCategoryName = "Ghee",
                MainCategoryId = 1,
                CategoryId = 2,
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
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                ProductName = "PATANJALI Chakki Atta, Whole Wheat with Bran, Genhu ka Atta, Organic Flour (Whole-Gehuro otta)  (5 kg)",
                ProductDescription = "",
                ProductImage = "https://rukminim2.flixcart.com/image/280/280/xif0q/flour/d/u/z/-original-imagwhtwwm2ksbxe.jpeg?q=70",
                ProductPrice = 222,
                BrandId = 3,
                CategoryId = 3,
                SubCategoryId = 3,
                MainCategoryId = 1,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                ProductName = "Fortune Chakki Fresh Atta (Whole-Gehuro otta)  (10 kg)",
                ProductDescription = "",
                ProductImage = "https://rukminim2.flixcart.com/image/416/416/kqidx8w0/flour/h/s/p/chakki-fresh-atta-whole-wheat-flour-fortune-original-imag4gb3ggvam3fg.jpeg?q=70",
                ProductPrice = 405,
                BrandId = 4,
                CategoryId = 3,
                SubCategoryId = 4,
                MainCategoryId = 1,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                ProductName = "Saffola Gold Refined Cooking Rice Bran & Corn Blended Oil Pouch (Mishrita Tela)  (1 L)",
                ProductDescription = "",
                ProductImage = "https://rukminim2.flixcart.com/image/416/416/xif0q/edible-oil/g/g/k/-original-imaghuf2t32wgzhe.jpeg?q=70",
                ProductPrice = 170,
                BrandId = 5,
                CategoryId = 2,
                SubCategoryId = 5,
                MainCategoryId = 1,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                ProductName = "Gowardhan Pure Cow Ghee 750 ml Pouch",
                ProductDescription = "",
                ProductImage = "https://rukminim2.flixcart.com/image/416/416/xif0q/ghee/x/9/q/750-cow-1-pouch-gowardhan-original-imagvp7fntadfgrx.jpeg?q=70",
                ProductPrice = 439,
                BrandId = 6,
                CategoryId = 2,
                SubCategoryId = 6,
                MainCategoryId = 1,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now,
                IsActive = true
            });

        }
    }
}
