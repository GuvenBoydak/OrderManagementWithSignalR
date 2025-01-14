using SignalRApp.Domain.Enums;

namespace SignalRApp.Application.Dtos;

public record OrderDto(int Id,
    string TableNumber,
    OrderStatus Status,
    DateTime Date,
    decimal TotalPrice);
    