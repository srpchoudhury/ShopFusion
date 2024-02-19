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
    [Migration("20240219150811_productseedtablesdata")]
    partial class productseedtablesdata
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
                            CreatedDate = new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(201),
                            IsActive = true
                        },
                        new
                        {
                            Id = 2,
                            BrandName = "Fortune",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(238),
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
                            CreatedDate = new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(272),
                            IsActive = true
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Ghee & Oils",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(317),
                            IsActive = true
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
                            CreatedDate = new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(75),
                            IsActive = true,
                            MainCategoryName = "Staples"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(159),
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
                            Id = 3,
                            BrandId = 2,
                            CategoryId = 1,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(430),
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
                            CreatedDate = new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(465),
                            IsActive = true,
                            MainCategoryId = 1,
                            ProductDescription = "",
                            ProductImage = "https://rukminim2.flixcart.com/image/416/416/xif0q/pulses/0/g/n/-original-imagsy58yzw47w8f.jpeg?q=70",
                            ProductName = "Natureland Organics Urad Dal (Biri Dali) (Split)  (1 kg)",
                            ProductPrice = 200.0,
                            SubCategoryId = 2
                        });
                });

            modelBuilder.Entity("ShopFusion.Services.ProductAPI.Models.SubCategories", b =>
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
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(355),
                            IsActive = true,
                            SubCategoryName = "Toor Daal"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(393),
                            IsActive = true,
                            SubCategoryName = "Urad Daal"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
