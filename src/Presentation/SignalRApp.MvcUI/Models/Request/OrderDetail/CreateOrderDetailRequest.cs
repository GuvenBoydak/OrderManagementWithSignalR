namespace SignalRApp.MvcUI.Models.Request.OrderDetail;

public record CreateOrderDetailRequest(int Count,
    decimal UnitPrice,
    decimal TotalPrice,
    int ProductId,
    int OrderId);