using AutoMapper;
using SignalRApp.Application.Features.Discount.Commands.Create;
using SignalRApp.Application.Features.Discount.Commands.Update;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Mapping;

public class DiscountMapping:Profile
{
    public DiscountMapping()
    {
        CreateMap<Discount, CreateDiscountCommandRequest>().ReverseMap();
        CreateMap<Discount, UpdateDiscountCommandRequest>().ReverseMap();
    }
}