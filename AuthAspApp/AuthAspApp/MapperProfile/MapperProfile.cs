using AutoMapper;
using AuthAspApp.Entities;
using AuthAspApp.Models;

namespace AuthAspApp.MapperProfile
{
    public class MapperProfile : Profile
    {
        public MapperProfile() => CreateMap<User, UserViewModel>().ReverseMap();
    }
}
