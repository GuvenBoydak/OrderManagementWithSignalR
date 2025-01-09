using SignalRApp.Application.Features.Category;

namespace SignalRApp.Application.Features.Product.Queries;

public record ProductDto(int Id,
    string Name,
    string Description,
    decimal Price,
    string ImageUrl,
    CategoryDto Category);