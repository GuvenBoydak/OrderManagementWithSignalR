using AutoMapper;
using SignalRApp.Application.Features.About.Commands.Create;
using SignalRApp.Application.Features.About.Commands.Update;
using SignalRApp.Application.Features.About.Queries.GetAboutById;
using SignalRApp.Application.Features.About.Queries.GetAllAbout;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Mapping;

public class AboutMapping:Profile
{
    public AboutMapping()
    {
        CreateMap<About, CreateAboutCommandRequest>().ReverseMap();
        CreateMap<About, UpdateAboutCommandRequest>().ReverseMap();
        CreateMap<About, GetAllAboutDto>().ReverseMap();
        CreateMap<About, GetAboutByIdDto>().ReverseMap();
    }
}