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
                config.CreateMap<MainCategoryDto, MainCategory>().ReverseMap();
                config.CreateMap<BrandDto, Brands>().ReverseMap();
                config.CreateMap<CategoryDto, Categories>().ReverseMap();
                config.CreateMap<SubCategoryDto, SubCategories>().ReverseMap();
               
            });
            return mappingConfig;
        }
    }
}
