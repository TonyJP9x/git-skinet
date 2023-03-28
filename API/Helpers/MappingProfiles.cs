using API.Dto;
using AutoMapper;
using Core.Entity;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(p => p.ProductType, o => o.MapFrom(s => s.ProductType.Name))
                .ForMember(p => p.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name));
        }
    }
}