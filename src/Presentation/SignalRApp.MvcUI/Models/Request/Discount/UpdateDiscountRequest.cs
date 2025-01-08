namespace SignalRApp.MvcUI.Models.Request.Discount;

public record UpdateDiscountRequest(int Id,string Title,decimal Amount,string Description,string ImageUrl);