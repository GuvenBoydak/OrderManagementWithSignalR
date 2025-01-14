using AutoMapper;
using SignalRApp.Application.Dtos;
using SignalRApp.Application.Features.Product.Commands.Create;
using SignalRApp.Application.Features.Product.Commands.Update;
using SignalRApp.Application.Features.Product.Queries;
using SignalRApp.Application.Features.Product.Queries.GetProductById;
using SignalRApp.Application.Features.Product.Queries.GetProductsWithCategory;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Mapping;

public class ProductMapping:Profile
{
    public ProductMapping()
    {
        CreateMap<Product, CreateProductCommandRequest>().ReverseMap();
        CreateMap<Product, UpdateProductCommandRequest>().ReverseMap();
        CreateMap<Product, GetProductsWithCategoryDto>();
        CreateMap<Product, GetProductByIdDto>();
        CreateMap<Product, ProductDto>();
    }
}