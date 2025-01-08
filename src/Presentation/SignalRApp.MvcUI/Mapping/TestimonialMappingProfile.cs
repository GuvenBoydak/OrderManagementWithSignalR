using AutoMapper;
using SignalRApp.MvcUI.Models.Request.Testimonial;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.Mapping;

public class TestimonialMappingProfile:Profile
{
    public TestimonialMappingProfile()
    {
        CreateMap<TestimonialResponse, UpdateTestimonialRequest>().ReverseMap();
    }
}