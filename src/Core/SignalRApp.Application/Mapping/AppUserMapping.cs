using AutoMapper;
using SignalRApp.Application.Features.AppUser.Commands.RegiserAppUser;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Mapping;

public class AppUserMapping:Profile
{
    public AppUserMapping()
    {
        CreateMap<AppUser, RegisterAppUserCommandRequest>().ReverseMap();
    }
}