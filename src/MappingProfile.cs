using System;
using AutoMapper;
using Domain.Entities.Models;

using Shared.DTO;

namespace src;


public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<UserForRegistrationDto, User>();
    }
}