namespace SignalRApp.Application.Features.Basket.Commands.Delete;

public record DeleteBasketCommandRequest(int Id):ICommand<DeleteBasketCommandResponse>;