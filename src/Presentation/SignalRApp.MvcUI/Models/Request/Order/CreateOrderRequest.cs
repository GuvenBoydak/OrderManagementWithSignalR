namespace SignalRApp.MvcUI.Models.Request.Order;

public record CreateOrderRequest(string TableNumber,string Description,DateTime Date,decimal TotalPrice);