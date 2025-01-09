using SignalRApp.Domain.Enums;

namespace SignalRApp.Application.Features.Order.Commands.Create;

public record CreateOrderCommandRequest(string TableNumber,OrderStatus Status,DateTime Date,decimal TotalPrice):ICommand<CreateOrderCommandResponse>;