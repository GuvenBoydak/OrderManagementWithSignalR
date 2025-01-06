using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Discount.Commands.Update;

public class UpdateDiscountCommandHandler(IDiscountService discountService):ICommandHandler<UpdateDiscountCommandRequest,UpdateDiscountCommandResponse>
{
    public async Task<UpdateDiscountCommandResponse> Handle(UpdateDiscountCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await discountService.UpdateAsync(request,cancellationToken));
    }
}