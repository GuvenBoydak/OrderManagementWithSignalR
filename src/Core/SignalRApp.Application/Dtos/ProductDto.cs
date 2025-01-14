namespace SignalRApp.Application.Dtos;

public record ProductDto(int Id,
    string Name,
    string Description,
    decimal Price,
    string ImageUrl,
    CategoryDto Category);