using AutoMapper;
using SignalRApp.Application.Features.SocialMedia.Commands.Create;
using SignalRApp.Application.Features.SocialMedia.Commands.Update;
using SignalRApp.Application.Features.SocialMedia.Queries.GetAllSocialMedia;
using SignalRApp.Application.Features.SocialMedia.Queries.GetSocialMediaById;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Mapping;

public class SocialMediaMapping:Profile
{
    public SocialMediaMapping()
    {
        CreateMap<SocialMedia, CreateSocialMediaCommandRequest>().ReverseMap();
        CreateMap<SocialMedia, UpdateSocialMediaCommandRequest>().ReverseMap();
        CreateMap<SocialMedia, GetAllSocialMediaDto>().ReverseMap();
        CreateMap<SocialMedia, GetSocialMediaByIdDto>().ReverseMap();
    }
}