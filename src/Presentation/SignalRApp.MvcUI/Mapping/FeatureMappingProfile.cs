using AutoMapper;
using SignalRApp.MvcUI.Models.Request.Feature;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.Mapping;

public class FeatureMappingProfile:Profile
{
    public FeatureMappingProfile()
    {
        CreateMap<FeatureResponse, UpdateFeatureRequest>().ReverseMap();
    }
}