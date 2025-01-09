using SignalRApp.Domain.Enums;

namespace SignalRApp.Application.Features.Order.Queries.GetAllOrders;

public record GetAllOrdersDto(int Id,
    string TableNumber,
    OrderStatus Status,
    DateTime Date,
    decimal TotalPrice);