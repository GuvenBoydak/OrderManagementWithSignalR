using SignalRApp.Application.Features.Category.Queries.GetPassiveCategory;
using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Category.Queries.GetPassiveCategoryCount;

public class GetPassiveCategoryCountQueryHandler(ICategoryService categoryService):IQueryHandler<GetPassiveCategoryCountQueryRequest,GetPassiveCategoryCountQueryResponse>
{
    public async Task<GetPassiveCategoryCountQueryResponse> Handle(GetPassiveCategoryCountQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await categoryService.GetCountAsync(x=> x.IsDeleted == true));
    }
}