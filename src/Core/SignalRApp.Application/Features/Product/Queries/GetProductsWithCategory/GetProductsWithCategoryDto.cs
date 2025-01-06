using SignalRApp.Application.Features.Category;

namespace SignalRApp.Application.Features.Product.Queries.GetProductsWithCategory;

public record GetProductsWithCategoryDto(
    int Id,
    string Name,
    string Description,
    decimal Price,
    string ImageUrl,
    bool Status,
    CategoryDto Category);