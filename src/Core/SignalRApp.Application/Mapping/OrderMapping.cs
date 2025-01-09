using AutoMapper;
using SignalRApp.Application.Features.Order.Commands.Create;
using SignalRApp.Application.Features.Order.Commands.Update;
using SignalRApp.Application.Features.Order.Queries;
using SignalRApp.Application.Features.Order.Queries.GetAllOrders;
using SignalRApp.Application.Features.Order.Queries.GetOrderById;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Mapping;

public class OrderMapping:Profile
{
    public OrderMapping()
    {
        CreateMap<Order, CreateOrderCommandRequest>().ReverseMap();
        CreateMap<Order, UpdateOrderCommandRequest>().ReverseMap();
        CreateMap<Order, GetAllOrdersDto>().ReverseMap();
        CreateMap<Order, GetOrderByIdDto>().ReverseMap();
        CreateMap<Order, OrderDto>().ReverseMap();
    }
}