using SignalRApp.Application.Dtos;
using SignalRApp.Application.Features.Category;

namespace SignalRApp.Application.Features.Product.Queries.GetProductById;

public record GetProductByIdDto(int Id,
    string Name,
    string Description,
    decimal Price,
    string ImageUrl,
    CategoryDto Category);