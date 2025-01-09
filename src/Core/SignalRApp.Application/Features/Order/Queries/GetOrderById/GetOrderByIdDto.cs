using SignalRApp.Domain.Enums;

namespace SignalRApp.Application.Features.Order.Queries.GetOrderById;

public record GetOrderByIdDto(int Id,
    string TableNumber,
    OrderStatus Status,
    DateTime Date,
    decimal TotalPrice);