using ShopFusion.Services.ShoppingCartAPI.Models.Dto;

namespace ShopFusion.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
