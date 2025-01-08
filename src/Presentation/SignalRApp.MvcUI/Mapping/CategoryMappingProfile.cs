using AutoMapper;
using SignalRApp.MvcUI.Models.Request.Category;
using SignalRApp.MvcUI.Models.Response;

namespace SignalRApp.MvcUI.Mapping;

public class CategoryMappingProfile:Profile
{
    public CategoryMappingProfile()
    {
        CreateMap<CategoryResponse, UpdateCategoryRequest>().ReverseMap();
    }
}