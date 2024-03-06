using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopFusion.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class newDatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(7623));

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "BrandName", "CreatedBy", "CreatedDate", "IsActive", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 7, "ITC", "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(7655), true, null, null },
                    { 8, "Flipkart Supermart", "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(7686), true, null, null },
                    { 9, "Beyond Snack", "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(7718), true, null, null },
                    { 10, "Cadbury", "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(7753), true, null, null },
                    { 11, "Sunfeast", "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(7785), true, null, null },
                    { 12, "UNIBIC", "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(7817), true, null, null },
                    { 13, "Coca Cola", "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(7851), true, null, null },
                    { 14, "Pepsi", "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(7882), true, null, null },
                    { 15, "Red Bull", "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(7914), true, null, null },
                    { 16, "Sting", "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(7946), true, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryImage", "CategoryName", "CreatedBy", "CreatedDate", "IsActive", "MainCategoryId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 4, "https://rukminim2.flixcart.com/www/100/100/promos/09/06/2017/ffad029d-5b1e-4de7-a91f-0bbe1803e197.png?q=90", "Biscuits", "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8077), true, 2, null, null },
                    { 5, "https://rukminim2.flixcart.com/www/100/100/promos/05/07/2017/f5433b1c-955d-47e2-83a5-0dbfb240de13.png?q=90", "Chips, Namkeen & Snacks", "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8108), true, 2, null, null },
                    { 6, "https://rukminim2.flixcart.com/www/100/100/promos/05/07/2017/93d975ff-8921-480a-afeb-13864520f568.png?q=90", "Soft Drinks", "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8141), true, 2, null, null },
                    { 12, "https://rukminim2.flixcart.com/www/100/100/promos/09/06/2017/38deea34-44ce-4650-a1fb-60f1c0172feb.png?q=90", "Dal's & Pulses", "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(7982), true, 1, null, null }
                });

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreatedBy", "CreatedDate", "IsActive", "MainCategoryId", "ProductDescription", "ProductImage", "ProductName", "ProductPrice", "SubCategoryId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 9, 12, 4, "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(9083), true, 2, "", "https://rukminim2.flixcart.com/image/416/416/xif0q/cookie-biscuit/x/e/c/-original-imagnz5hhdcjpzcz.jpeg?q=70", "UNIBIC Cashew Badam Cookies  (300 g)", 48.0, 7, null, null },
                    { 10, 11, 4, "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(9222), true, 2, "", "https://rukminim2.flixcart.com/image/416/416/xif0q/cookie-biscuit/d/v/l/64-orange-creme-1-sunfeast-bounce-original-imagmfuzdhxzh5t9.jpeg?q=70", "Sunfeast Bounce Orange Creme Biscotti  (20% Extra in Pack)  (63.2 g)", 9.0, 8, null, null },
                    { 11, 10, 4, "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(9333), true, 2, "", "https://rukminim2.flixcart.com/image/416/416/xif0q/cookie-biscuit/v/o/f/-original-imagwcjwu6gyaxqb.jpeg?q=70", "Cadbury Oreo Chocolate Flavour Biscuit Cream Sandwich  (131.25 g)", 36.0, 8, null, null },
                    { 12, 7, 5, "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(9371), true, 2, "", "https://rukminim2.flixcart.com/image/416/416/l58iaa80/snack-savourie/k/r/x/-original-imagfybhffnh9uzz.jpeg?q=70", "Bingo Tedhe Medhe Masala Tadka (Namkeen)  (80 g)", 14.0, 9, null, null },
                    { 13, 8, 5, "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(9405), true, 2, "", "https://rukminim2.flixcart.com/image/416/416/l58iaa80/snack-savourie/k/r/x/-original-imagfybhffnh9uzz.jpeg?q=70", "Flipkart Supermart Boondi (Bhakarwadi)  (300 g)", 14.0, 9, null, null },
                    { 14, 7, 5, "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(9438), true, 2, "", "https://rukminim2.flixcart.com/image/416/416/l58iaa80/snack-savourie/k/r/x/-original-imagfybhffnh9uzz.jpeg?q=70", "Bingo Mad Angles Tomato Madness Chips  (66 g)", 17.0, 10, null, null },
                    { 15, 9, 5, "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(9697), true, 2, "", "https://rukminim2.flixcart.com/image/416/416/xif0q/chips/t/z/m/-original-imaghu8kqf7wtrh2.jpeg?q=70", "Beyond Snack Kerala Banana Salt and Black Pepper Chips  (75 g)", 40.0, 10, null, null },
                    { 16, 13, 6, "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(9731), true, 2, "", "https://rukminim2.flixcart.com/image/416/416/kynb6vk0/aerated-drink/a/k/7/-original-imagau2nhx7aytga.jpeg?q=70", "Coca-Cola Diet Coke Can  (300 ml)", 36.0, 11, null, null },
                    { 17, 14, 6, "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(9763), true, 2, "", "https://rukminim2.flixcart.com/image/416/416/j5y7gcw0-1/aerated-drink/h/z/r/2-25-na-mirinda-original-imaewj89mxyhdkrf.jpeg?q=70", "MiRiNDA Soft Drink PET Bottle  (2.25 L)", 77.0, 11, null, null },
                    { 18, 15, 6, "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(9805), true, 2, "", "https://rukminim2.flixcart.com/image/416/416/xif0q/energy-sport-drink-mix/r/n/c/-original-imagjt5c6m3hzqtd.jpeg?q=70", "Red Bull Original Energy Drink  (350 ml, Plain Flavored)", 146.0, 12, null, null },
                    { 19, 16, 6, "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(9853), true, 2, "", "https://rukminim2.flixcart.com/image/416/416/jwqpocw0/energy-sport-drink-mix/e/h/y/250-na-sting-original-imafhcqqzh6vhmvt.jpeg?q=70", "Sting Energy Drink  (250 ml, Plain Flavored)", 26.0, 12, null, null }
                });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedDate", "IsActive", "MainCategoryId", "SubCategoryName", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 7, 4, "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8388), true, 2, "Cookies", null, null },
                    { 8, 4, "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8432), true, 2, "Cream Biscuits", null, null },
                    { 9, 5, "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8467), true, 2, "Namkeen", null, null },
                    { 10, 5, "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8503), true, 2, "Chips", null, null },
                    { 11, 6, "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8537), true, 2, "Cold Drinks", null, null },
                    { 12, 6, "Admin", new DateTime(2024, 3, 6, 19, 11, 27, 24, DateTimeKind.Local).AddTicks(8571), true, 2, "Energy & Sports Drinks", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 12);

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
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryImage", "CategoryName", "CreatedBy", "CreatedDate", "IsActive", "MainCategoryId", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, "https://rukminim2.flixcart.com/www/100/100/promos/09/06/2017/38deea34-44ce-4650-a1fb-60f1c0172feb.png?q=90", "Dal's & Pulses", "Admin", new DateTime(2024, 3, 6, 17, 16, 44, 419, DateTimeKind.Local).AddTicks(8617), true, 1, null, null });

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
    }
}
