﻿using AutoMapper;
using NetTemplate.DAL.Data.Entities;
using NetTemplate.DAL.Data.Requests.Auth;
using NetTemplate.DAL.Data.Responses.Auth;

namespace NetTemplate.DAL.Mappers
{
    public class AuthMapper : Profile
    {
        public AuthMapper()
        {
            CreateMap<LoginRequest, Staff>()
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password));

            CreateMap<Staff, LoginResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.SystemRole))
                .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.Department))
                .ForMember(dest => dest.avatarUrl, opt => opt.MapFrom(src => src.Avatar));
        }
    }
}
