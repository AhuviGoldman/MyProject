using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using System;

namespace MyProject.Services
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Role, RoleDTO>()
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Description))
                .ReverseMap();

            CreateMap<Claim, ClaimDTO>()
                .ForMember(dest => dest.Policy, opt => opt.MapFrom(src => src.Policy))
                .ReverseMap();

            CreateMap<Permission, PermissionDTO>()
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Description))
                .ReverseMap();
        }
    }
}
