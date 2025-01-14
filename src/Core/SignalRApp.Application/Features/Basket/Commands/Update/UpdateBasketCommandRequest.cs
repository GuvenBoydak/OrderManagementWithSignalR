namespace SignalRApp.Application.Features.Basket.Commands.Update;

public record UpdateBasketCommandRequest(int Id, decimal Price, int Count, decimal TotalPrice, int ProductId):ICommand<UpdateBasketCommandResponse>;