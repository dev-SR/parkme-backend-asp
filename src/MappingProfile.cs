using AutoMapper;
using Domain.Entities.Models;
using Shared.DTO.Auth;
using Shared.DTO.Parking;
using Shared.DTO.Test;

namespace src;


public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<RegistrationRequestDto, MyUser>();

        // Map (User,roles) to UserResponseDto
        CreateMap<(MyUser user, IList<string> roles), UserResponseDto>()
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


        // CreateMap<ParkingSpace, ParkingSpaceDto>()
        // .ForMember(dest => dest.VehicleType, opt => opt.MapFrom(src => src.VehicleType.ToString()));

        CreateMap<ParkingLot, ParkingLotDto>();

        CreateMap<TestDBCreate, TestDB>();
        CreateMap<TestDB, TesDbRecord>();

    }
}