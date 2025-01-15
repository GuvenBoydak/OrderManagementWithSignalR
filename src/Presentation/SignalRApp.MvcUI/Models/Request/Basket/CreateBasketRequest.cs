namespace SignalRApp.MvcUI.Models.Request.Basket;

public record CreateBasketRequest(decimal Price,
    int Count,
    decimal TotalPrice,
    int ProductId,
    int MenuTableId);