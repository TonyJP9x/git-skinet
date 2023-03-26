using API.Dto;
using AutoMapper;
using Core.Entity;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        protected MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>();
        }
    }
}