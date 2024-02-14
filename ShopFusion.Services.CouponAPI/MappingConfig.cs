using AutoMapper;
using ShopFusion.Services.CouponAPI.Models;
using ShopFusion.Services.CouponAPI.Models.Dto;

namespace ShopFusion.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
