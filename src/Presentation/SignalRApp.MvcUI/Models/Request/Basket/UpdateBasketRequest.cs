namespace SignalRApp.MvcUI.Models.Request.Basket;

public record UpdateBasketRequest(int Id,
    decimal Price,
    int Count,
    decimal TotalPrice,
    int ProductId,
    int MenuTableId);