namespace SignalRApp.Application.Features.OrderDetail.Commands.Delete;

public record DeleteOrderDetailCommandRequest(int Id):ICommand<DeleteOrderDetailCommandResponse>;