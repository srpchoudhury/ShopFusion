using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopFusion.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class categoryImageAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryImage",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryImage", "CreatedDate" },
                values: new object[] { "https://rukminim2.flixcart.com/www/100/100/promos/09/06/2017/38deea34-44ce-4650-a1fb-60f1c0172feb.png?q=90", new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryImage", "CreatedDate" },
                values: new object[] { "https://rukminim2.flixcart.com/www/100/100/promos/06/11/2023/bab3c31e-0be6-4f67-b9a6-cb341fa1f034.png?q=90", new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryImage", "CreatedDate" },
                values: new object[] { "https://rukminim2.flixcart.com/www/100/100/promos/05/07/2017/cd819684-9369-468b-895c-ef9b57b6b059.png?q=90", new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8892));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryImage",
                table: "Categories");

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

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(6323));

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(7147));

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

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 20, 21, 48, 54, 498, DateTimeKind.Local).AddTicks(6823));
        }
    }
}
