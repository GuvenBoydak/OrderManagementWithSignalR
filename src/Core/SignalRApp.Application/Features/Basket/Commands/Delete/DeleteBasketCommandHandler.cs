using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Basket.Commands.Delete;

public class DeleteBasketCommandHandler(IBasketService basketService):ICommandHandler<DeleteBasketCommandRequest,DeleteBasketCommandResponse>
{
    public async Task<DeleteBasketCommandResponse> Handle(DeleteBasketCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await basketService.DeleteAsync(request,cancellationToken));
    }
}