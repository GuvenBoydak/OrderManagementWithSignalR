using SignalRApp.MvcUI.Models.Enums;

namespace SignalRApp.MvcUI.Models.Request.Order;

public record CreateOrderRequest(string TableNumber,OrderStatus Status,DateTime Date,decimal TotalPrice);