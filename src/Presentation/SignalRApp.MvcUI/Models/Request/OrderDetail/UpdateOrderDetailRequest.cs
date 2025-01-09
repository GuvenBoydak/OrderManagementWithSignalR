namespace SignalRApp.MvcUI.Models.Request.OrderDetail;

public record UpdateOrderDetailRequest(int Id,
    int Count,
    decimal UnitPrice,
    decimal TotalPrice,
    int ProductId,
    int OrderId);