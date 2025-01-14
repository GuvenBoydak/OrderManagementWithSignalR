using AutoMapper;
using SignalRApp.Application.Dtos;
using SignalRApp.Application.Features.Category;
using SignalRApp.Application.Features.Category.Commands.Create;
using SignalRApp.Application.Features.Category.Commands.Update;
using SignalRApp.Application.Features.Category.Queries.GetAllCategories;
using SignalRApp.Application.Features.Category.Queries.GetCategoryById;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Mapping;

public class CategoryMapping:Profile
{
    public CategoryMapping()
    {
        CreateMap<Category, CreateCategoryCommandRequest>().ReverseMap();
        CreateMap<Category, UpdateCategoryCommandRequest>().ReverseMap();
        CreateMap<Category, GetAllCategoriesDto>().ReverseMap();
        CreateMap<Category, GetCategoryByIdDto>().ReverseMap();
        CreateMap<Category, CategoryDto>().ReverseMap();
    }
}