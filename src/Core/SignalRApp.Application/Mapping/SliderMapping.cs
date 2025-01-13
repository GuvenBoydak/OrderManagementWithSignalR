using AutoMapper;
using SignalRApp.Application.Features.Slider.Commands.Create;
using SignalRApp.Application.Features.Slider.Commands.Update;
using SignalRApp.Application.Features.Slider.Queries.GetAllSliders;
using SignalRApp.Application.Features.Slider.Queries.GetSliderById;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Mapping;

public class SliderMapping:Profile
{
    public SliderMapping()
    {
        CreateMap<Slider, CreateSliderCommandRequest>().ReverseMap();
        CreateMap<Slider, UpdateSliderCommandRequest>().ReverseMap();
        CreateMap<Slider, GetAllSliderDto>().ReverseMap();
        CreateMap<Slider, GetSliderByIdDto>().ReverseMap();
    }
}