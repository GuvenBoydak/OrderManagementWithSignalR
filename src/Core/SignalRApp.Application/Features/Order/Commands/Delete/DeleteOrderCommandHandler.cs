using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Order.Commands.Delete;

public class DeleteOrderCommandHandler(IOrderService orderService):ICommandHandler<DeleteOrderCommandRequest,DeleteOrderCommandResponse>
{
    public async Task<DeleteOrderCommandResponse> Handle(DeleteOrderCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await orderService.DeleteAsync(request.Id,cancellationToken));
    }
}