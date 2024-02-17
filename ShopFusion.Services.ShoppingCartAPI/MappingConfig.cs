using AutoMapper;
using ShopFusion.Services.ShoppingCartAPI.Models;
using ShopFusion.Services.ShoppingCartAPI.Models.Dto;

namespace ShopFusion.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CartHeader, CartHeaderDto>().ReverseMap();
                config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap();
               
            });
            return mappingConfig;
        }
    }
}
