using AutoMapper;
using ShopFusion.Services.ProductAPI.Models;
using ShopFusion.Services.ProductAPI.Models.Dto;

namespace ShopFusion.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
               
            });
            return mappingConfig;
        }
    }
}
