using AutoMapper;
using Furzify.API.Entities;
using Furzify.API.Models.Band;

namespace Furzify.API.Extensions
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Band, BandDto>();
        }

    }
}