using AutoMapper;
using SignalRApp.Application.Features.Category.Commands.Create;
using SignalRApp.Application.Features.Category.Commands.Update;
using SignalRApp.Domain.Entities;

namespace SignalRApp.Application.Mapping;

public class CategoryMapping:Profile
{
    public CategoryMapping()
    {
        CreateMap<Category, CreateCategoryCommandRequest>().ReverseMap();
        CreateMap<Category, UpdateCategoryCommandRequest>().ReverseMap();
    }
}