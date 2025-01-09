using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Product.Queries.GetProductCount;

public class GetProductCountQueryHandler(IProductService productService):IQueryHandler<GetProductCountQueryRequest,GetProductCountQueryResponse>
{
    public async Task<GetProductCountQueryResponse> Handle(GetProductCountQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await productService.GetCountAsync());
    }
}