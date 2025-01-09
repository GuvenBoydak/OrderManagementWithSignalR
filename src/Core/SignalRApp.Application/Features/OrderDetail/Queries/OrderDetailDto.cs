using SignalRApp.Application.Features.Order.Queries;
using SignalRApp.Application.Features.Product;
using SignalRApp.Application.Features.Product.Queries;

namespace SignalRApp.Application.Features.OrderDetail.Queries;

public record OrderDetailDto(int Id,
    int Count,
    decimal UnitPrice,
    decimal TotalPrice,
    ProductDto Product,
    OrderDto Order);