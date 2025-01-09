using SignalRApp.MvcUI.Models.Enums;

namespace SignalRApp.MvcUI.Models.Response;

public record OrderResponse(int Id,
    string TableNumber,
    OrderStatus Status,
    DateTime Date,
    decimal TotalPrice);