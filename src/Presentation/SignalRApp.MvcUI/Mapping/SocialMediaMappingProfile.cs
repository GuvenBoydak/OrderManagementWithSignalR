using AutoMapper;
using SignalRApp.MvcUI.Models.Request.SocialMedia;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.Mapping;

public class SocialMediaMappingProfile:Profile
{
    public SocialMediaMappingProfile()
    {
        CreateMap<SocialMediaResponse, UpdateSocialMediaRequest>().ReverseMap();
    }
}