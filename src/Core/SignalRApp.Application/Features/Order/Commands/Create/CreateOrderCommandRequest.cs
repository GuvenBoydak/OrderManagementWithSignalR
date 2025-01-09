namespace SignalRApp.Application.Features.Order.Commands.Create;

public record CreateOrderCommandRequest(string TableNumber,string Description,DateTime Date,decimal TotalPrice):ICommand<CreateOrderCommandResponse>;