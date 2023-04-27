using AutoMapper;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTOs;

namespace NZWalks.API.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<AddRegionRequestDto, Region>().ReverseMap();
            CreateMap<UpdateRegionRequestDto, Region>().ReverseMap();

        }
    }
    // Only example

   /* public class UserDTO
    {
        public string FullName { get; set; }
    }

    public class UserDomain
    {
        public string Name { get; set; }
    }*/
}
