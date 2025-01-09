using SignalRApp.MvcUI.Models.Enums;

namespace SignalRApp.MvcUI.Models.Request.Order;

public record UpdateOrderRequest(int Id,string TableNumber,OrderStatus Status,DateTime Date,decimal TotalPrice);