using AutoMapper;
using SignalRApp.MvcUI.Models.Request.OrderDetail;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.Mapping;

public class OrderDetailMappingProfile:Profile
{
    public OrderDetailMappingProfile()
    {
        CreateMap<OrderDetailResponse, UpdateOrderDetailRequest>().ReverseMap();
    }
}