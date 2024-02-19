using System.ComponentModel.DataAnnotations;

namespace ShopFusion.Services.ProductAPI.Models
{
    public class SubCategoryDto
    {
        public int Id { get; set; }
        public string SubCategoryName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; }

    }
}
