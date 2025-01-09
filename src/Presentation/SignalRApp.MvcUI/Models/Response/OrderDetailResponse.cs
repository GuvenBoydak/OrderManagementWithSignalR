namespace SignalRApp.MvcUI.Models.Response;

public record OrderDetailResponse(int Id,
    int Count,
    decimal UnitPrice,
    decimal TotalPrice,
    ProductResponse Product,
    OrderResponse Order);