namespace SignalRApp.MvcUI.Models.Request.Discount;

public record CreateDiscountRequest(string Title,decimal Amount,string Description,string ImageUrl);