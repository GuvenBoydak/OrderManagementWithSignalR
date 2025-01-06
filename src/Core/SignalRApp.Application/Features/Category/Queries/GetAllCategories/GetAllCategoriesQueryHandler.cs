using SignalRApp.Application.Interfaces.Service;

namespace SignalRApp.Application.Features.Category.Queries.GetAllCategories;

public class GetAllCategoriesQueryHandler(ICategoryService categoryService):IQueryHandler<GetAllCategoriesQueryRequest,GetAllCategoriesQueryResponse>
{
    public async Task<GetAllCategoriesQueryResponse> Handle(GetAllCategoriesQueryRequest request, CancellationToken cancellationToken)
    {
        return new(await categoryService.GetAllAsync());
    }
}