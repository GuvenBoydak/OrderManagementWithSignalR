using SignalRApp.Domain.Enums;

namespace SignalRApp.Application.Features.Order.Commands.Update;

public record UpdateOrderCommandRequest(int Id,string TableNumber,OrderStatus Status,DateTime Date,decimal TotalPrice):ICommand<UpdateOrderCommandResponse>;