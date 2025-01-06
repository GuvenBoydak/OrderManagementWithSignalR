namespace SignalRApp.Application.Features.Discount.Queries.GetDiscountById;

public record GetDiscountByIdDto(int Id,
    string Title,
    decimal Amount,
    string Description,
    string ImageUrl);