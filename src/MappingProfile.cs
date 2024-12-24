using AutoMapper;
using Domain.Entities.Models;
using Shared.DTO.Auth;

namespace src;


public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<RegistrationRequestDto, User>();

        // Map (User,roles) to UserResponseDto
        CreateMap<(User user, IList<string> roles), UserResponseDto>()
        .ForMember(des => des.Id, opt => opt.MapFrom(src => src.user.Id))
        .ForMember(des => des.Email, opt => opt.MapFrom(src => src.user.Email))
        .ForMember(des => des.FirstName, opt => opt.MapFrom(src => src.user.FirstName))
        .ForMember(des => des.LastName, opt => opt.MapFrom(src => src.user.LastName))
        .ForMember(des => des.Roles, opt => opt.MapFrom(src => src.roles));

        // Map (UserResponseDto,accessToken,refreshToken) to UserResponseDto
        CreateMap<(UserResponseDto user, string accessToken, string refreshToken), LoginResponseDto>()
        .ForMember(dest => dest.AccessToken, opt => opt.MapFrom(src => src.accessToken))
        .ForMember(dest => dest.RefreshToken, opt => opt.MapFrom(src => src.refreshToken))
        .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.user));

    }
}