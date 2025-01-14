using SignalRApp.Application.Features.Product.Queries;

namespace SignalRApp.Application.Dtos;

public record OrderDetailDto(int Id,
    int Count,
    decimal UnitPrice,
    decimal TotalPrice,
    ProductDto Product,
    OrderDto Order);