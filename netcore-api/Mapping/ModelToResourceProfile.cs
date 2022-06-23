
using AutoMapper;
using netcore_api.Domain.Models;
using netcore_api.Domain.Models.Queries;
using netcore_api.Extensions;
using netcore_api.Resources;

namespace netcore_api.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            CreateMap<Product, ProductResource>()
                .ForMember(src => src.UnitOfMeasurement,
                           opt => opt.MapFrom(src => src.UnitOfMeasurement.ToDescriptionString()));

            CreateMap<QueryResult<Product>, QueryResultResource<ProductResource>>();
        }
    }
}