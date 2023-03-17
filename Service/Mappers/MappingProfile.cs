
﻿using AutoMapper;
using Domain.Entities;
using Service.DTOs;


namespace Service.Mappers
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<UserForCreationDto, User>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
        }

    }
}