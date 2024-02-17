using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopFusion.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class addProductAndSeedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<double>(type: "float", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "CategoryName", "ProductDescription", "ProductImage", "ProductName", "ProductPrice", "SubCategoryId", "SubCategoryName" },
                values: new object[,]
                {
                    { 1, 1, "Mens T-Shirts", "", "https://rukminim2.flixcart.com/image/832/832/xif0q/shirt/q/7/a/l-men-regular-fit-printed-spread-collar-casual-shirt-dhruva-original-imagueaqamscp4es.jpeg?q=70&crop=false", "Men Regular Fit Checkered Spread Collar Casual Shirt", 850.0, 1, "RM CREATION" },
                    { 2, 1, "Mens T-Shirts", "", "", "Men Regular Fit Printed Spread Collar Casual Shirt", 1299.0, 1, "RM CREATION" },
                    { 3, 1, "Mens T-Shirts", "", "", "Men Regular Fit Printed Spread Collar Casual Shirt", 999.0, 1, "RM CREATION" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
