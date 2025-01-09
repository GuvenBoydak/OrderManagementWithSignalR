using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Order.Commands.Update;

public class UpdateOrderCommandHandler(IOrderService orderService):ICommandHandler<UpdateOrderCommandRequest,UpdateOrderCommandResponse>
{
    public async Task<UpdateOrderCommandResponse> Handle(UpdateOrderCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await orderService.UpdateAsync(request,cancellationToken));
    }
}