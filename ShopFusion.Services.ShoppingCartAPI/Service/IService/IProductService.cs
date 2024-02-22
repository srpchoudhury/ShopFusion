using ShopFusion.Services.ShoppingCartAPI.Models.Dto;

namespace ShopFusion.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
