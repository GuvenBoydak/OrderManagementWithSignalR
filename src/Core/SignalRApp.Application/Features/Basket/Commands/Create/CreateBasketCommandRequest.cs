namespace SignalRApp.Application.Features.Basket.Commands.Create;

public record CreateBasketCommandRequest(decimal Price,int Count,decimal TotalPrice,int ProductId,int MenuTableId):ICommand<CreateBasketCommandResponse>;