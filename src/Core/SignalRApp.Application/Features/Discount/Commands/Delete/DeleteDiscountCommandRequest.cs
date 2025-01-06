namespace SignalRApp.Application.Features.Discount.Commands.Delete;

public record DeleteDiscountCommandRequest(int Id):ICommand<DeleteDiscountCommandResponse>;