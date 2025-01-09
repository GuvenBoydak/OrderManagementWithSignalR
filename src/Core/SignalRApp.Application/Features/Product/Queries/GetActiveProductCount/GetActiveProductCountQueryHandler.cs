using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Product.Queries.GetActiveProductCount;

public class GetActiveProductCountQueryHandler(IProductService productService):IQueryHandler<GetActiveProductCountQueryRequest,GetActiveProductCountQueryResponse>
{
    public async Task<GetActiveProductCountQueryResponse> Handle(GetActiveProductCountQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await productService.GetCountAsync(x=> x.IsDeleted == false));
    }
}