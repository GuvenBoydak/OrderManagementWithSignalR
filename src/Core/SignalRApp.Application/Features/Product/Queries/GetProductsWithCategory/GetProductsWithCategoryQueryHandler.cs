using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Product.Queries.GetProductsWithCategory;

public class GetProductsWithCategoryQueryHandler(IProductService productService)
    : IQueryHandler<GetProductsWithCategoryQueryRequest, GetProductsWithCategoryQueryResponse>
{
    public async Task<GetProductsWithCategoryQueryResponse> Handle(GetProductsWithCategoryQueryRequest request,
        CancellationToken cancellationToken)
    {
        return new(await productService.GetProductsWithCategoryAsync());
    }
}