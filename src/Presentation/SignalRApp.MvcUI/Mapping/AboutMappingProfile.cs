using AutoMapper;
using SignalRApp.MvcUI.Models.Request.About;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.Mapping;

public class AboutMappingProfile:Profile
{
    public AboutMappingProfile()
    {
        CreateMap<AboutResponse, UpdateAboutRequest>().ReverseMap();
    }
}
