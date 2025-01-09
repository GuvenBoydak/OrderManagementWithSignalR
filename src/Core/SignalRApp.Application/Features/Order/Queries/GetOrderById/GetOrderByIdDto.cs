using SignalRApp.Application.Features.OrderDetail.Queries;

namespace SignalRApp.Application.Features.Order.Queries.GetOrderById;

public record GetOrderByIdDto(int Id,
    string TableNumber,
    string Description,
    DateTime Date,
    decimal TotalPrice,
    OrderDetailDto OrderDetail);