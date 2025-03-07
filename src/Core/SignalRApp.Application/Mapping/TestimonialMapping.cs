using AutoMapper;
using SignalRApp.Application.Features.Testimonial.Commands.Create;
using SignalRApp.Application.Features.Testimonial.Commands.Update;
using SignalRApp.Application.Features.Testimonial.Queries.GetAllTestimonial;
using SignalRApp.Application.Features.Testimonial.Queries.GetTestimonialById;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Mapping;

public class TestimonialMapping:Profile
{
    public TestimonialMapping()
    {
        CreateMap<Testimonial, CreateTestimonialCommandRequest>().ReverseMap();
        CreateMap<Testimonial, UpdateTestimonialCommandRequest>().ReverseMap();
        CreateMap<Testimonial, GetAllTestimonialDto>().ReverseMap();
        CreateMap<Testimonial, GetTestimonialByIdDto>().ReverseMap();
    }
}