using SignalRApp.Domain.Enums;

namespace SignalRApp.Application.Features.Order.Queries;

public record OrderDto(int Id,
    string TableNumber,
    OrderStatus Status,
    DateTime Date,
    decimal TotalPrice);
    