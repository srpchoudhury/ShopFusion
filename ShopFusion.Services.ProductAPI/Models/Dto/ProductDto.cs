using System.ComponentModel.DataAnnotations;

namespace ShopFusion.Services.ProductAPI.Models.Dto
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImage { get; set; }
        public double ProductPrice { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }

    }
}
