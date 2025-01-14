using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Basket.Commands.Update;

public class UpdateBasketCommandHandler(IBasketService basketService):ICommandHandler<UpdateBasketCommandRequest,UpdateBasketCommandResponse>
{
    public async Task<UpdateBasketCommandResponse> Handle(UpdateBasketCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await basketService.UpdateAsync(request,cancellationToken));
    }
}