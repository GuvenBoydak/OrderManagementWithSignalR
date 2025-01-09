using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Product.Queries.GetPassiveProductCount;

public record GetPassiveProductCountQueryHandler(IProductService ProductService):IQueryHandler<GetPassiveProductCountQueryRequest,GetPassiveProductCountQueryResponse>
{
    public async Task<GetPassiveProductCountQueryResponse> Handle(GetPassiveProductCountQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await ProductService.GetCountAsync(x=> x.IsDeleted == true));
    }
}