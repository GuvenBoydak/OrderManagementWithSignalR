using AutoMapper;
using SignalRApp.Application.Features.Basket.Commands.Create;
using SignalRApp.Application.Features.Basket.Commands.Update;
using SignalRApp.Application.Features.Basket.Queries.GetAllBaskets;
using SignalRApp.Application.Features.Basket.Queries.GetBasketById;
using SignalRApp.Application.Features.Basket.Queries.GetBasketByMenuTableId;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Mapping;

public class BasketMapping:Profile
{
    public BasketMapping()
    {
        CreateMap<Basket, CreateBasketCommandRequest>().ReverseMap();
        CreateMap<Basket, UpdateBasketCommandRequest>().ReverseMap();
        CreateMap<Basket, GetAllBasketDto>().ReverseMap();
        CreateMap<Basket, GetBasketByIdDto>().ReverseMap();
        CreateMap<Basket, GetBasketByMenuTableIdDto>().ReverseMap();
    }
}