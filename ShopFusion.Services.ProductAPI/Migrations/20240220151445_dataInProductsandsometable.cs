using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopFusion.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class dataInProductsandsometable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "BrandName", "CreatedBy", "CreatedDate", "IsActive", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 3, "Patanjali", "Admin", new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5007), true, null, null },
                    { 4, "Fortune", "Admin", new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5036), true, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedBy", "CreatedDate", "IsActive", "MainCategoryId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 3, "Atta & Flours", "Admin", new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5132), true, 2, null, null });

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreatedBy", "CreatedDate", "IsActive", "MainCategoryId", "ProductDescription", "ProductImage", "ProductName", "ProductPrice", "SubCategoryId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 5, 3, 3, "Admin", new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5367), true, 2, "", "https://rukminim2.flixcart.com/image/280/280/xif0q/flour/d/u/z/-original-imagwhtwwm2ksbxe.jpeg?q=70", "PATANJALI Chakki Atta, Whole Wheat with Bran, Genhu ka Atta, Organic Flour (Whole-Gehuro otta)  (5 kg)", 222.0, 3, null, null },
                    { 6, 4, 3, "Admin", new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5416), true, 2, "", "https://rukminim2.flixcart.com/image/416/416/kqidx8w0/flour/h/s/p/chakki-fresh-atta-whole-wheat-flour-fortune-original-imag4gb3ggvam3fg.jpeg?q=70", "Fortune Chakki Fresh Atta (Whole-Gehuro otta)  (10 kg)", 405.0, 4, null, null }
                });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedDate", "IsActive", "MainCategoryId", "SubCategoryName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 3, 3, "Admin", new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5238), true, 2, "Wheat Atta", null, null },
                    { 4, 3, "Admin", new DateTime(2024, 2, 20, 20, 44, 44, 331, DateTimeKind.Local).AddTicks(5270), true, 2, "Rava & Sooji", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 18, 56, 17, 836, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 18, 56, 17, 836, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 18, 56, 17, 836, DateTimeKind.Local).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 18, 56, 17, 836, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 18, 56, 17, 836, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 18, 56, 17, 836, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 18, 56, 17, 836, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 18, 56, 17, 836, DateTimeKind.Local).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 18, 56, 17, 836, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 18, 56, 17, 836, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 18, 56, 17, 836, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 18, 56, 17, 836, DateTimeKind.Local).AddTicks(4100));
        }
    }
}
