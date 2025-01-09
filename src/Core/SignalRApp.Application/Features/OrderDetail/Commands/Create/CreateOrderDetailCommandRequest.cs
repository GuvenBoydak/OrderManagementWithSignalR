namespace SignalRApp.Application.Features.OrderDetail.Commands.Create;

public record CreateOrderDetailCommandRequest(int Count,decimal UnitPrice,decimal TotalPrice,int ProductId,int OrderId):ICommand<CreateOrderDetailCommandResponse>;