namespace SignalRApp.Application.Features.Discount.Commands.Update;

public record UpdateDiscountCommandRequest(int Id,
    string Title,
    decimal Amount,
    string Description,
    string ImageUrl):ICommand<UpdateDiscountCommandResponse>;