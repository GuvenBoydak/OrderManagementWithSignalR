using SignalRApp.Application.Features.Category.Queries.GetActiveCategory;
using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Category.Queries.GetActiveCategoryCount;

public class GetActiveCategoryCountQueryHandler(ICategoryService categoryService):IQueryHandler<GetActiveCategoryCountQueryRequest,GetActiveCategoryCountQueryResponse>
{
    public async Task<GetActiveCategoryCountQueryResponse> Handle(GetActiveCategoryCountQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await categoryService.GetCountAsync(x=> x.IsDeleted == false));
    }
}