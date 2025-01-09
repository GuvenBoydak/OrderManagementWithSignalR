namespace SignalRApp.Application.Features.Order.Commands.Delete;

public record DeleteOrderCommandRequest(int Id):ICommand<DeleteOrderCommandResponse>;