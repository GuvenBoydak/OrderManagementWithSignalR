using SignalRApp.Application.Dtos;

namespace SignalRApp.Application.Features.Basket.Queries.GetBasketByMenuTableId;

public record GetBasketByMenuTableIdDto(int Id,
    decimal Price,
    int Count,
    decimal TotalPrice,
    ProductDto Product,
    MenuTableDto MenuTable);