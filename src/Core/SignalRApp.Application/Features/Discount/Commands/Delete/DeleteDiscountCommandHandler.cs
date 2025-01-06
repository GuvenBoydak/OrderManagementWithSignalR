using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Discount.Commands.Delete;

public class DeleteDiscountCommandHandler(IDiscountService discountService):ICommandHandler<DeleteDiscountCommandRequest,DeleteDiscountCommandResponse>
{
    public async Task<DeleteDiscountCommandResponse> Handle(DeleteDiscountCommandRequest request, CancellationToken cancellationToken)
    {
        return new(await discountService.DeleteAsync(request,cancellationToken));
    }
}