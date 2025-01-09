using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.OrderDetail.Commands.Create;

public class CreateOrderDetailCommandHandler(IOrderDetailService orderDetailService):ICommandHandler<CreateOrderDetailCommandRequest,CreateOrderDetailCommandResponse>
{
    public async Task<CreateOrderDetailCommandResponse> Handle(CreateOrderDetailCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await orderDetailService.AddAsync(request,cancellationToken));
    }
}