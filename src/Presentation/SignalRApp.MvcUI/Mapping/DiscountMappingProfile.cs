using AutoMapper;
using SignalRApp.MvcUI.Models.Request.Discount;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.Mapping;

public class DiscountMappingProfile:Profile
{
    public DiscountMappingProfile()
    {
        CreateMap<DiscountResponse, UpdateDiscountRequest>().ReverseMap();
    }
}