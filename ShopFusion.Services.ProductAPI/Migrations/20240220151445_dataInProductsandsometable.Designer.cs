﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopFusion.Services.ProductAPI.Data;

#nullable disable

namespace ShopFusion.Services.ProductAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240220151445_dataInProductsandsometable")]
    partial class dataInProductsandsometable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShopFusion.Services.ProductAPI.Models.Brands", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandName = "Nature Land",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(4941),
                            IsActive = true
                        },
                        new
                        {
                            Id = 2,
                            BrandName = "Fortune",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(4976),
                            IsActive = true
                        },
                        new
                        {
                            Id = 3,
                            BrandName = "Patanjali",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5007),
                            IsActive = true
                        },
                        new
                        {
                            Id = 4,
                            BrandName = "Fortune",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5036),
                            IsActive = true
                        });
                });

            modelBuilder.Entity("ShopFusion.Services.ProductAPI.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MainCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Dal's & Pulses",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5067),
                            IsActive = true,
                            MainCategoryId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Ghee & Oils",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5102),
                            IsActive = true,
                            MainCategoryId = 1
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Atta & Flours",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5132),
                            IsActive = true,
                            MainCategoryId = 2
                        });
                });

            modelBuilder.Entity("ShopFusion.Services.ProductAPI.Models.MainCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("MainCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MainCategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(4856),
                            IsActive = true,
                            MainCategoryName = "Staples"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(4897),
                            IsActive = true,
                            MainCategoryName = "Snacks & Beverages"
                        });
                });

            modelBuilder.Entity("ShopFusion.Services.ProductAPI.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MainCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProductPrice")
                        .HasColumnType("float");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CategoryId = 1,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(4722),
                            IsActive = true,
                            MainCategoryId = 1,
                            ProductDescription = "",
                            ProductImage = "https://rukminim2.flixcart.com/image/416/416/ke7ff680/pulses/z/m/x/500-kabuli-chana-kabuli-chana-natureland-organics-original-imafuy3hfkx4qw7d.jpeg?q=70",
                            ProductName = "Natureland Organics Kabuli Chana (Kabuli Buta) (Whole)  (500 g)",
                            ProductPrice = 126.0,
                            SubCategoryId = 1
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 1,
                            CategoryId = 1,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(4812),
                            IsActive = true,
                            MainCategoryId = 1,
                            ProductDescription = "",
                            ProductImage = "https://rukminim2.flixcart.com/image/416/416/kqpj4i80/pulses/r/a/z/1-arhar-dal-arhar-dal-natureland-organics-original-imag4npb8twt4dwz.jpeg?q=70",
                            ProductName = "Natureland Organics Yellow Toor/Arhar Dal (Harada Dali) (Split)  (1 kg)",
                            ProductPrice = 1299.0,
                            SubCategoryId = 1
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 2,
                            CategoryId = 1,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5305),
                            IsActive = true,
                            MainCategoryId = 1,
                            ProductDescription = "",
                            ProductImage = "https://rukminim2.flixcart.com/image/416/416/xif0q/pulses/g/4/h/-original-imagpgzhcvgcyaxg.jpeg?q=70",
                            ProductName = "Tata Sampann White Urad Dal (Biri Dali) (Whole)  (1 kg)",
                            ProductPrice = 200.0,
                            SubCategoryId = 2
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 2,
                            CategoryId = 1,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5338),
                            IsActive = true,
                            MainCategoryId = 1,
                            ProductDescription = "",
                            ProductImage = "https://rukminim2.flixcart.com/image/416/416/xif0q/pulses/0/g/n/-original-imagsy58yzw47w8f.jpeg?q=70",
                            ProductName = "Natureland Organics Urad Dal (Biri Dali) (Split)  (1 kg)",
                            ProductPrice = 200.0,
                            SubCategoryId = 2
                        },
                        new
                        {
                            Id = 5,
                            BrandId = 3,
                            CategoryId = 3,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5367),
                            IsActive = true,
                            MainCategoryId = 2,
                            ProductDescription = "",
                            ProductImage = "https://rukminim2.flixcart.com/image/280/280/xif0q/flour/d/u/z/-original-imagwhtwwm2ksbxe.jpeg?q=70",
                            ProductName = "PATANJALI Chakki Atta, Whole Wheat with Bran, Genhu ka Atta, Organic Flour (Whole-Gehuro otta)  (5 kg)",
                            ProductPrice = 222.0,
                            SubCategoryId = 3
                        },
                        new
                        {
                            Id = 6,
                            BrandId = 4,
                            CategoryId = 3,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5416),
                            IsActive = true,
                            MainCategoryId = 2,
                            ProductDescription = "",
                            ProductImage = "https://rukminim2.flixcart.com/image/416/416/kqidx8w0/flour/h/s/p/chakki-fresh-atta-whole-wheat-flour-fortune-original-imag4gb3ggvam3fg.jpeg?q=70",
                            ProductName = "Fortune Chakki Fresh Atta (Whole-Gehuro otta)  (10 kg)",
                            ProductPrice = 405.0,
                            SubCategoryId = 4
                        });
                });

            modelBuilder.Entity("ShopFusion.Services.ProductAPI.Models.SubCategories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MainCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("SubCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SubCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5171),
                            IsActive = true,
                            MainCategoryId = 1,
                            SubCategoryName = "Toor Daal"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5205),
                            IsActive = true,
                            MainCategoryId = 1,
                            SubCategoryName = "Urad Daal"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5238),
                            IsActive = true,
                            MainCategoryId = 2,
                            SubCategoryName = "Wheat Atta"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5270),
                            IsActive = true,
                            MainCategoryId = 2,
                            SubCategoryName = "Rava & Sooji"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
