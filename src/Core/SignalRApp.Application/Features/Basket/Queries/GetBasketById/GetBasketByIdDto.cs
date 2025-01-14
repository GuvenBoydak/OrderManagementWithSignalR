using SignalRApp.Application.Dtos;
using SignalRApp.Application.Features.OrderDetail.Queries;
using SignalRApp.Application.Features.Product.Queries;

namespace SignalRApp.Application.Features.Basket.Queries.GetBasketById;

public record GetBasketByIdDto(int Id,
    decimal Price,
    int Count,
    decimal TotalPrice,
    ProductDto Product,
    MenuTableDto MenuTable);