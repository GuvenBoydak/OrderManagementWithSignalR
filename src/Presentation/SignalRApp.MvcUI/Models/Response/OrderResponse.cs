namespace SignalRApp.MvcUI.Models.Response;

public record OrderResponse(int Id,
    string TableNumber,
    string Description,
    DateTime Date,
    decimal TotalPrice,
    OrderDetailResponse OrderDetail);