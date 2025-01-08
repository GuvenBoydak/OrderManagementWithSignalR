using AutoMapper;
using SignalRApp.MvcUI.Models.Request.Product;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.Mapping;

public class ProductMappingProfile:Profile
{
    public ProductMappingProfile()
    {
        CreateMap<ProductResponse, UpdateProductRequest>().ForMember(dest => dest.CategoryId,
            opt => opt.MapFrom(src => src.Category.Id)).ReverseMap();
    }
}