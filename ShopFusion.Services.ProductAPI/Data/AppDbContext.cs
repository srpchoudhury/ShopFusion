using Microsoft.EntityFrameworkCore;
using ShopFusion.Services.ProductAPI.Models;
using static System.Net.WebRequestMethods;

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
            modelBuilder.Entity<Brands>().HasData(new Brands
            {
                Id = 7,
                BrandName = "ITC",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Brands>().HasData(new Brands
            {
                Id = 8,
                BrandName = "Flipkart Supermart",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Brands>().HasData(new Brands
            {
                Id = 9,
                BrandName = "Beyond Snack",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Brands>().HasData(new Brands
            {
                Id = 10,
                BrandName = "Cadbury",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Brands>().HasData(new Brands
            {
                Id = 11,
                BrandName = "Sunfeast",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Brands>().HasData(new Brands
            {
                Id = 12,
                BrandName = "UNIBIC",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Brands>().HasData(new Brands
            {
                Id = 13,
                BrandName = "Coca Cola",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Brands>().HasData(new Brands
            {
                     Id = 14,
                     BrandName = "Pepsi",
                     CreatedBy = "Admin",
                     CreatedDate = DateTime.Now,
                     IsActive = true
            });
            modelBuilder.Entity<Brands>().HasData(new Brands
            {
                Id = 15,
                BrandName = "Red Bull",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Brands>().HasData(new Brands
            {
                Id = 16,
                BrandName = "Sting",
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
            modelBuilder.Entity<Categories>().HasData(new Categories
            {
                Id = 4,
                CategoryName = "Biscuits",
                CategoryImage = "https://rukminim2.flixcart.com/www/100/100/promos/09/06/2017/ffad029d-5b1e-4de7-a91f-0bbe1803e197.png?q=90",
                MainCategoryId = 2,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Categories>().HasData(new Categories
            {
                    Id = 5,
                CategoryName = "Chips, Namkeen & Snacks",
                    CategoryImage = "https://rukminim2.flixcart.com/www/100/100/promos/05/07/2017/f5433b1c-955d-47e2-83a5-0dbfb240de13.png?q=90",
                    MainCategoryId = 2,
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    IsActive = true
            });
            modelBuilder.Entity<Categories>().HasData(new Categories
            {
                Id = 6,
                CategoryName = "Soft Drinks",
                CategoryImage = "https://rukminim2.flixcart.com/www/100/100/promos/05/07/2017/93d975ff-8921-480a-afeb-13864520f568.png?q=90",
                MainCategoryId = 2,
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
            modelBuilder.Entity<SubCategories>().HasData(new SubCategories
            {
                Id = 7,
                SubCategoryName = "Cookies",
                MainCategoryId = 2,
                CategoryId = 4,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<SubCategories>().HasData(new SubCategories
            {
                Id = 8,
                SubCategoryName = "Cream Biscuits",
                MainCategoryId = 2,
                CategoryId = 4,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<SubCategories>().HasData(new SubCategories
            {
                Id = 9,
                SubCategoryName = "Namkeen",
                MainCategoryId = 2,
                CategoryId = 5,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<SubCategories>().HasData(new SubCategories
            {
                Id = 10,
                SubCategoryName = "Chips",
                MainCategoryId = 2,
                CategoryId = 5,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<SubCategories>().HasData(new SubCategories
            {
                Id = 11,
                SubCategoryName = "Cold Drinks",
                MainCategoryId = 2,
                CategoryId = 6,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<SubCategories>().HasData(new SubCategories
            {
                Id = 12,
                SubCategoryName = "Energy & Sports Drinks",
                MainCategoryId = 2,
                CategoryId = 6,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsActive = true
            });

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
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                ProductName = "UNIBIC Cashew Badam Cookies  (300 g)",
                ProductDescription = "",
                ProductImage = "https://rukminim2.flixcart.com/image/416/416/xif0q/cookie-biscuit/x/e/c/-original-imagnz5hhdcjpzcz.jpeg?q=70",
                ProductPrice = 48,
                BrandId = 12,
                CategoryId = 4,
                SubCategoryId = 7,
                MainCategoryId = 2,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                ProductName = "Sunfeast Bounce Orange Creme Biscotti  (20% Extra in Pack)  (63.2 g)",
                ProductDescription = "",
                ProductImage = "https://rukminim2.flixcart.com/image/416/416/xif0q/cookie-biscuit/d/v/l/64-orange-creme-1-sunfeast-bounce-original-imagmfuzdhxzh5t9.jpeg?q=70",
                ProductPrice = 9,
                BrandId = 11,
                CategoryId = 4,
                SubCategoryId = 8,
                MainCategoryId = 2,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                ProductName = "Cadbury Oreo Chocolate Flavour Biscuit Cream Sandwich  (131.25 g)",
                ProductDescription = "",
                ProductImage = "https://rukminim2.flixcart.com/image/416/416/xif0q/cookie-biscuit/v/o/f/-original-imagwcjwu6gyaxqb.jpeg?q=70",
                ProductPrice = 36,
                BrandId = 10,
                CategoryId = 4,
                SubCategoryId = 8,
                MainCategoryId = 2,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                ProductName = "Bingo Tedhe Medhe Masala Tadka (Namkeen)  (80 g)",
                ProductDescription = "",
                ProductImage = "https://rukminim2.flixcart.com/image/416/416/l58iaa80/snack-savourie/k/r/x/-original-imagfybhffnh9uzz.jpeg?q=70",
                ProductPrice = 14,
                BrandId = 7,
                CategoryId = 5,
                SubCategoryId = 9,
                MainCategoryId = 2,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                ProductName = "Flipkart Supermart Boondi (Bhakarwadi)  (300 g)",
                ProductDescription = "",
                ProductImage = "https://rukminim2.flixcart.com/image/416/416/l4yi7bk0/snack-savourie/a/7/2/300-boondi-1-pouch-flipkart-supermart-original-imagfqnne4zhcjdd.jpeg?q=70",
                ProductPrice = 14,
                BrandId = 8,
                CategoryId = 5,
                SubCategoryId = 9,
                MainCategoryId = 2,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Product>().HasData(new Product
                 {
                     Id = 14,
                     ProductName = "Bingo Mad Angles Tomato Madness Chips  (66 g)",
                     ProductDescription = "",
                     ProductImage = "https://rukminim2.flixcart.com/image/416/416/kpbipow0/chips/a/n/f/mad-angles-tomato-madness-bingo-original-imag3ks6zmmzackg.jpeg?q=70",
                     ProductPrice = 17,
                     BrandId = 7,
                     CategoryId = 5,
                     SubCategoryId = 10,
                     MainCategoryId = 2,
                     CreatedBy = "Admin",
                     CreatedDate = System.DateTime.Now,
                     IsActive = true
                 });
            modelBuilder.Entity<Product>().HasData(new Product
                {
                    Id = 15,
                    ProductName = "Beyond Snack Kerala Banana Salt and Black Pepper Chips  (75 g)",
                    ProductDescription = "",
                    ProductImage = "https://rukminim2.flixcart.com/image/416/416/xif0q/chips/t/z/m/-original-imaghu8kqf7wtrh2.jpeg?q=70",
                    ProductPrice = 40,
                    BrandId = 9,
                    CategoryId = 5,
                    SubCategoryId = 10,
                    MainCategoryId = 2,
                    CreatedBy = "Admin",
                    CreatedDate = System.DateTime.Now,
                    IsActive = true
                });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                ProductName = "Coca-Cola Diet Coke Can  (300 ml)",
                ProductDescription = "",
                ProductImage = "https://rukminim2.flixcart.com/image/416/416/kynb6vk0/aerated-drink/a/k/7/-original-imagau2nhx7aytga.jpeg?q=70",
                ProductPrice = 36,
                BrandId = 13,
                CategoryId = 6,
                SubCategoryId = 11,
                MainCategoryId = 2,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                ProductName = "MiRiNDA Soft Drink PET Bottle  (2.25 L)",
                ProductDescription = "",
                ProductImage = "https://rukminim2.flixcart.com/image/416/416/j5y7gcw0-1/aerated-drink/h/z/r/2-25-na-mirinda-original-imaewj89mxyhdkrf.jpeg?q=70",
                ProductPrice = 77,
                BrandId = 14,
                CategoryId = 6,
                SubCategoryId = 11,
                MainCategoryId = 2,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                ProductName = "Red Bull Original Energy Drink  (350 ml, Plain Flavored)",
                ProductDescription = "",
                ProductImage = "https://rukminim2.flixcart.com/image/416/416/xif0q/energy-sport-drink-mix/r/n/c/-original-imagjt5c6m3hzqtd.jpeg?q=70",
                ProductPrice = 146,
                BrandId = 15,
                CategoryId = 6,
                SubCategoryId = 12,
                MainCategoryId = 2,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now,
                IsActive = true
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                ProductName = "Sting Energy Drink  (250 ml, Plain Flavored)",
                ProductDescription = "",
                ProductImage = "https://rukminim2.flixcart.com/image/416/416/jwqpocw0/energy-sport-drink-mix/e/h/y/250-na-sting-original-imafhcqqzh6vhmvt.jpeg?q=70",
                ProductPrice = 26,
                BrandId = 16,
                CategoryId = 6,
                SubCategoryId = 12,
                MainCategoryId = 2,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now,
                IsActive = true
            });



        }
    }
}
