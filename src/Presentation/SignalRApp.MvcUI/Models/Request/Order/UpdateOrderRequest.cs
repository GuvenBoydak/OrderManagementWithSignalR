namespace SignalRApp.MvcUI.Models.Request.Order;

public record UpdateOrderRequest(int Id,string TableNumber,string Description,DateTime Date,decimal TotalPrice);