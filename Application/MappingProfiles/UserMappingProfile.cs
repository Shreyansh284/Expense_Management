using Application.DTOs.UserDTOs;
using AutoMapper;
using Core.Entities;

namespace Application.MappingProfiles;

public class UserMappingProfile:Profile
{
    public UserMappingProfile()
    {
        CreateMap<RegisterUserDTO, User>();
        CreateMap<User, UserDisplayDTO>();
    }
}