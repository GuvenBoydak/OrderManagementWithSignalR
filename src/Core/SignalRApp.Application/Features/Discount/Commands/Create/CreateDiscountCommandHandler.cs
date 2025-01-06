using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Discount.Commands.Create;

public class CreateDiscountCommandHandler(IDiscountService discountService):ICommandHandler<CreateDiscountCommandRequest,CreateDiscountCommandResponse>
{
    public async Task<CreateDiscountCommandResponse> Handle(CreateDiscountCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await discountService.AddAsync(request,cancellationToken));
    }
}