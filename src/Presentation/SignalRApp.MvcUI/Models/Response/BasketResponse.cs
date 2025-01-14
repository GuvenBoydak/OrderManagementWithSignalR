namespace SignalRApp.MvcUI.Models.Response;

public record BasketResponse(int Id,
    decimal Price,
    int Count,
    decimal TotalPrice,
    ProductResponse Product,
    MenuTableResponse MenuTable);