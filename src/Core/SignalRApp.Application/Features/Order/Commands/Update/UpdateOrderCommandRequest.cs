namespace SignalRApp.Application.Features.Order.Commands.Update;

public record UpdateOrderCommandRequest(int Id,string TableNumber,string Description,DateTime Date,decimal TotalPrice):ICommand<UpdateOrderCommandResponse>;