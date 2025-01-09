using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Order.Commands.Create;

public class CreateOrderCommandHandler(IOrderService orderService):ICommandHandler<CreateOrderCommandRequest,CreateOrderCommandResponse>
{
    public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await orderService.AddAsync(request,cancellationToken));
    }
}