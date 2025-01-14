using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Basket.Commands.Create;

public class CreateBasketCommandHandler(IBasketService basketService):ICommandHandler<CreateBasketCommandRequest,CreateBasketCommandResponse>
{
    public async Task<CreateBasketCommandResponse> Handle(CreateBasketCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await basketService.AddAsync(request,cancellationToken));
    }
}