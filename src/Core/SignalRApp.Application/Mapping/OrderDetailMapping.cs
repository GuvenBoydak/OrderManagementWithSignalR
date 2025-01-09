using AutoMapper;
using SignalRApp.Application.Features.OrderDetail.Commands.Create;
using SignalRApp.Application.Features.OrderDetail.Commands.Update;
using SignalRApp.Application.Features.OrderDetail.Queries;
using SignalRApp.Application.Features.OrderDetail.Queries.GetAllOrderDetails;
using SignalRApp.Application.Features.OrderDetail.Queries.GetOrderDetailById;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Mapping;

public class OrderDetailMapping:Profile
{
    public OrderDetailMapping()
    {
        CreateMap<OrderDetail, CreateOrderDetailCommandRequest>().ReverseMap();
        CreateMap<OrderDetail, UpdateOrderDetailCommandRequest>().ReverseMap();
        CreateMap<OrderDetail, GetAllOrderDetailDto>().ReverseMap();
        CreateMap<OrderDetail, GetOrderDetailByIdDto>().ReverseMap();
        CreateMap<OrderDetail, OrderDetailDto>().ReverseMap();
    }
}