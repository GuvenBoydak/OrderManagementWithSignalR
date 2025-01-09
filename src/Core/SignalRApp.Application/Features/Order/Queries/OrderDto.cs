using SignalRApp.Application.Features.OrderDetail.Queries;

namespace SignalRApp.Application.Features.Order.Queries;

public record OrderDto(int Id,
    string TableNumber,
    string Description,
    DateTime Date,
    decimal TotalPrice,
    OrderDetailDto OrderDetail);
    