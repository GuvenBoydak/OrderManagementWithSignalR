using AutoMapper;
using SignalRApp.Application.Features.Discount.Commands.Create;
using SignalRApp.Application.Features.Discount.Commands.Update;
using SignalRApp.Application.Features.Discount.Queries.GetAllDiscount;
using SignalRApp.Application.Features.Discount.Queries.GetDiscountById;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Mapping;

public class DiscountMapping:Profile
{
    public DiscountMapping()
    {
        CreateMap<Discount, CreateDiscountCommandRequest>().ReverseMap();
        CreateMap<Discount, UpdateDiscountCommandRequest>().ReverseMap();
        CreateMap<Discount, GetAllDiscountDto>().ReverseMap();
        CreateMap<Discount, GetDiscountByIdDto>().ReverseMap();
    }
}