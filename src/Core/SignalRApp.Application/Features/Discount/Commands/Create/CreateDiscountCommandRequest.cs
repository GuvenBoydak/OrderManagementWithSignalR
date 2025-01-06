namespace SignalRApp.Application.Features.Discount.Commands.Create;

public record CreateDiscountCommandRequest(string Title,decimal Amount,string Description,string ImageUrl):ICommand<CreateDiscountCommandResponse>;