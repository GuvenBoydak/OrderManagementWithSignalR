using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.OrderDetail.Commands.Update;

public class UpdateOrderDetailCommandHandler(IOrderDetailService orderDetailService):ICommandHandler<UpdateOrderDetailCommandRequest,UpdateOrderDetailCommandResponse>
{
    public async Task<UpdateOrderDetailCommandResponse> Handle(UpdateOrderDetailCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await orderDetailService.UpdateAsync(request,cancellationToken));
    }
}