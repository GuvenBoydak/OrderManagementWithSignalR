using AutoMapper;
using SignalRApp.MvcUI.Models.Request.Slider;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.Mapping;

public class SliderMappingProfile:Profile
{
    public SliderMappingProfile()
    {
        CreateMap<SliderResponse, UpdateSliderRequest>().ReverseMap();
    }
}