using AutoMapper;
using SignalRApp.Application.Features.Product.Commands.Create;
using SignalRApp.Application.Features.Product.Commands.Update;
using SignalRApp.Application.Features.Product.Queries.GetProductsWithCategory;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Mapping;

public class ProductMapping:Profile
{
    public ProductMapping()
    {
        CreateMap<Product, CreateProductCommandRequest>().ReverseMap();
        CreateMap<Product, UpdateProductCommandRequest>().ReverseMap();
        CreateMap<Product, GetProductsWithCategoryDto>()
            .ForMember(dest => dest.CategoryName,
                opt => opt.MapFrom(src => src.Category.Name)).ReverseMap();
    }
}