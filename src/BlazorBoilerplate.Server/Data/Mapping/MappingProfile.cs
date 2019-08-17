﻿using AutoMapper;
using BlazorBoilerplate.Server.Middleware.Wrappers;
using BlazorBoilerplate.Server.Models;
using BlazorBoilerplate.Shared.Dto;

namespace BlazorBoilerplate.Server.Data.Mapping
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Create automap mapping profiles
        /// </summary>
        public MappingProfile()
        {
            CreateMap<TodoDto, Todo>();
            CreateMap<ApiResponseDto, APIResponse>();
            //CreateMap<Account, AccountViewModel>();
            //CreateMap<UserViewModel, User>()
            //    .ForMember(dest => dest.DecryptedPassword, opts => opts.MapFrom(src => src.Password))
            //    .ForMember(dest => dest.Roles, opts => opts.MapFrom(src => string.Join(";", src.Roles)));
            //CreateMap<User, UserViewModel>()
            //    .ForMember(dest => dest.Password, opts => opts.MapFrom(src => src.DecryptedPassword))
            //    .ForMember(dest => dest.Roles, opts => opts.MapFrom(src => src.Roles.Split(";", StringSplitOptions.RemoveEmptyEntries)));
            //CreateMissingTypeMaps = true;
        }
    }
}
