using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Category.Queries.GetCategoryCount;

public class GetCategoryCountQueryHandler(ICategoryService categoryService):IQueryHandler<GetCategoryCountQueryRequest,GetCategoryCountQueryResponse>
{
    public async Task<GetCategoryCountQueryResponse> Handle(GetCategoryCountQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await categoryService.GetCountAsync());
    }
}