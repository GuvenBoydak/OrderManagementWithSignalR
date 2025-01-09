using AutoMapper;
using SignalRApp.MvcUI.Models.Request.Order;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.Mapping;

public class OrderMappingProfile:Profile
{
    public OrderMappingProfile()
    {
        CreateMap<OrderResponse, UpdateOrderRequest>().ReverseMap();
    }
}