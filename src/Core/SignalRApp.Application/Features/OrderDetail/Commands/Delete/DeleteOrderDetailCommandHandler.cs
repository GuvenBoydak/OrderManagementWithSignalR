using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.OrderDetail.Commands.Delete;

public class DeleteOrderDetailCommandHandler(IOrderDetailService orderDetailService):ICommandHandler<DeleteOrderDetailCommandRequest,DeleteOrderDetailCommandResponse>
{
    public async Task<DeleteOrderDetailCommandResponse> Handle(DeleteOrderDetailCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await orderDetailService.DeleteAsync(request.Id,cancellationToken));
    }
}