using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopFusion.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class productseedtablesdataok : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 19, 20, 46, 24, 856, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 19, 20, 46, 24, 856, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 19, 20, 46, 24, 856, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 19, 20, 46, 24, 856, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 19, 20, 46, 24, 856, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 19, 20, 46, 24, 856, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 19, 20, 46, 24, 856, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 19, 20, 46, 24, 856, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreatedBy", "CreatedDate", "IsActive", "MainCategoryId", "ProductDescription", "ProductImage", "ProductName", "ProductPrice", "SubCategoryId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, 1, "Admin", new DateTime(2024, 2, 19, 20, 46, 24, 856, DateTimeKind.Local).AddTicks(5836), true, 1, "", "https://rukminim2.flixcart.com/image/416/416/ke7ff680/pulses/z/m/x/500-kabuli-chana-kabuli-chana-natureland-organics-original-imafuy3hfkx4qw7d.jpeg?q=70", "Natureland Organics Kabuli Chana (Kabuli Buta) (Whole)  (500 g)", 126.0, 1, null, null },
                    { 2, 1, 1, "Admin", new DateTime(2024, 2, 19, 20, 46, 24, 856, DateTimeKind.Local).AddTicks(5926), true, 1, "", "https://rukminim2.flixcart.com/image/416/416/kqpj4i80/pulses/r/a/z/1-arhar-dal-arhar-dal-natureland-organics-original-imag4npb8twt4dwz.jpeg?q=70", "Natureland Organics Yellow Toor/Arhar Dal (Harada Dali) (Split)  (1 kg)", 1299.0, 1, null, null }
                });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 19, 20, 46, 24, 856, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 19, 20, 46, 24, 856, DateTimeKind.Local).AddTicks(6209));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 19, 20, 38, 10, 407, DateTimeKind.Local).AddTicks(393));
        }
    }
}
