namespace SignalRApp.Application.Features.Discount.Queries.GetAllDiscount;

public record GetAllDiscountDto(int Id,
    string Title,
    decimal Amount,
    string Description,
    string ImageUrl);