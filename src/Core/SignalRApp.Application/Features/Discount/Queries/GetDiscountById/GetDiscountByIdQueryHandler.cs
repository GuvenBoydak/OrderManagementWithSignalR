using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Discount.Queries.GetDiscountById;

public class GetDiscountByIdQueryHandler(IDiscountService discountService):IQueryHandler<GetDiscountByIdQueryRequest,GetDiscountByIdQueryResponse>
{
    public async Task<GetDiscountByIdQueryResponse> Handle(GetDiscountByIdQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await discountService.GetByIdAsync(request.Id));
    }
}