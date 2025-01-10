using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Product.Queries.GetProductNameByMinPrice;

public class GetProductNameByMinPriceQueryHandler(IProductService productService):IQueryHandler<GetProductNameByMinPriceQueryRequest,GetProductNameByMinPriceQueryResponse>
{
    public async Task<GetProductNameByMinPriceQueryResponse> Handle(GetProductNameByMinPriceQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await productService.ProductNameByMinPriceAsync());
    }
}