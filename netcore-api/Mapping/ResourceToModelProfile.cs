using AutoMapper;
using netcore_api.Domain.Models;
using netcore_api.Domain.Models.Queries;
using netcore_api.Resources;

namespace netcore_api.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();

            CreateMap<SaveProductResource, Product>()
                .ForMember(src => src.UnitOfMeasurement, opt => opt.MapFrom(src => (EUnitOfMeasurement)src.UnitOfMeasurement));

            CreateMap<ProductsQueryResource, ProductsQuery>();
        }
    }
}