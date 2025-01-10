using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Product.Queries.GetProductNameByMaxPrice;

public class GetProductNameByMaxPriceQueryHandler(IProductService productService):IQueryHandler<GetProductNameByMaxPriceQueryRequest,GetProductNameByMaxPriceQueryResponse>
{
    public async Task<GetProductNameByMaxPriceQueryResponse> Handle(GetProductNameByMaxPriceQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await productService.GetProductNameByMaxPriceAsync());
    }
}