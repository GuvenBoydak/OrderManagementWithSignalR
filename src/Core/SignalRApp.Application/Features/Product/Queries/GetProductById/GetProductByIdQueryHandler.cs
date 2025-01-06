using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Product.Queries.GetProductById;

public class GetProductByIdQueryHandler(IProductService productService):IQueryHandler<GetProductByIdQueryRequest,GetProductByIdQueryResponse>
{
    public async Task<GetProductByIdQueryResponse> Handle(GetProductByIdQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await productService.GetByIdAsync(request.Id));
    }
}