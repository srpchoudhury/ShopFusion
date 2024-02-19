using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopFusion.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class productseedtablesdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "BrandName", "CreatedBy", "CreatedDate", "IsActive", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Nature Land", "Admin", new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(201), true, null, null },
                    { 2, "Fortune", "Admin", new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(238), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedBy", "CreatedDate", "IsActive", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Dal's & Pulses", "Admin", new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(272), true, null, null },
                    { 2, "Ghee & Oils", "Admin", new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(317), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "MainCategory",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "MainCategoryName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(75), true, "Staples", null, null },
                    { 2, "Admin", new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(159), true, "Snacks & Beverages", null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreatedBy", "CreatedDate", "IsActive", "MainCategoryId", "ProductDescription", "ProductImage", "ProductName", "ProductPrice", "SubCategoryId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 3, 2, 1, "Admin", new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(430), true, 1, "", "https://rukminim2.flixcart.com/image/416/416/xif0q/pulses/g/4/h/-original-imagpgzhcvgcyaxg.jpeg?q=70", "Tata Sampann White Urad Dal (Biri Dali) (Whole)  (1 kg)", 200.0, 2, null, null },
                    { 4, 2, 1, "Admin", new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(465), true, 1, "", "https://rukminim2.flixcart.com/image/416/416/xif0q/pulses/0/g/n/-original-imagsy58yzw47w8f.jpeg?q=70", "Natureland Organics Urad Dal (Biri Dali) (Split)  (1 kg)", 200.0, 2, null, null }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "SubCategoryName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(355), true, "Toor Daal", null, null },
                    { 2, "Admin", new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(393), true, "Urad Daal", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
