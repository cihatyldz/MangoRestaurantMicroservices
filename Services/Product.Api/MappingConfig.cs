using AutoMapper;
using Product.Api.Models;
using Product.Api.Models.Dtos;

namespace Product.Api
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, MangoProduct>();
                config.CreateMap<MangoProduct, ProductDto>();
            });

            return mappingConfig;
        }
    }
}
