using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Discount.Queries.GetAllDiscount;

public class GetAllDiscountQueryHandler(IDiscountService discountService):IQueryHandler<GetAllDiscountQueryRequest,GetAllDiscountQueryResponse>
{
    public async Task<GetAllDiscountQueryResponse> Handle(GetAllDiscountQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await discountService.GetAllAsync());
    }
}