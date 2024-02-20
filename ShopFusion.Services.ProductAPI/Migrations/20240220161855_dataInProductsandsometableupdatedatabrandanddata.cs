using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopFusion.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class dataInProductsandsometableupdatedatabrandanddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(6198));

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "BrandName", "CreatedBy", "CreatedDate", "IsActive", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 5, "Saffola", "Admin", new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(6254), true, null, null },
                    { 6, "Gowardhan", "Admin", new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(6323), true, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreatedBy", "CreatedDate", "IsActive", "MainCategoryId", "ProductDescription", "ProductImage", "ProductName", "ProductPrice", "SubCategoryId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 7, 5, 2, "Admin", new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(7096), true, 1, "", "https://rukminim2.flixcart.com/image/416/416/xif0q/edible-oil/g/g/k/-original-imaghuf2t32wgzhe.jpeg?q=70", "Saffola Gold Refined Cooking Rice Bran & Corn Blended Oil Pouch (Mishrita Tela)  (1 L)", 170.0, 5, null, null },
                    { 8, 6, 2, "Admin", new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(7147), true, 1, "", "https://rukminim2.flixcart.com/image/416/416/xif0q/ghee/x/9/q/750-cow-1-pouch-gowardhan-original-imagvp7fntadfgrx.jpeg?q=70", "Gowardhan Pure Cow Ghee 750 ml Pouch", 439.0, 6, null, null }
                });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedDate", "IsActive", "MainCategoryId", "SubCategoryName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 5, 2, "Admin", new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(6766), true, 1, "Blended Oil", null, null },
                    { 6, 2, "Admin", new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(6823), true, 1, "Ghee", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 51, 23, 657, DateTimeKind.Local).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 51, 23, 657, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 51, 23, 657, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 51, 23, 657, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 51, 23, 657, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 51, 23, 657, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 51, 23, 657, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 51, 23, 657, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 51, 23, 657, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 51, 23, 657, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 51, 23, 657, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 51, 23, 657, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 51, 23, 657, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 51, 23, 657, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 51, 23, 657, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 51, 23, 657, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 51, 23, 657, DateTimeKind.Local).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 51, 23, 657, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 51, 23, 657, DateTimeKind.Local).AddTicks(2629));
        }
    }
}
