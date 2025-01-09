namespace SignalRApp.Application.Features.OrderDetail.Commands.Update;

public record UpdateOrderDetailCommandRequest(int Id,int Count,decimal UnitPrice,decimal TotalPrice):ICommand<UpdateOrderDetailCommandResponse>;