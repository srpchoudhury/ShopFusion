namespace ShopFusion.Services.ProductAPI.Models.Dto
{
    public class MainCategoryDto
    {
        public int Id { get; set; }
        public string MainCategoryName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
