using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Product.Queries.GetProductsAveragePrice;

public class GetProductsAveragePriceQueryHandler(IProductService productService):IQueryHandler<GetProductsAveragePriceQueryRequest,GetProductsAveragePriceQueryResponse>
{
    public async Task<GetProductsAveragePriceQueryResponse> Handle(GetProductsAveragePriceQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await productService.GetProductsAveragePriceAsync());
    }
}